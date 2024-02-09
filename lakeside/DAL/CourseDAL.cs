using lakeside.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using lakeside.DAL;
using lakeside.Models;

namespace lakeside.DAL
{
    public class CourseDAL : DAL
    {
        public bool AddNewCourse(Course c)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO Course VALUES('{c.TutorID}','{c.CourseName}','{c.Description}','{c.Duration}','{c.Capacity}','{c.Price}','{c.Level}')");

            return ExecuteNonQuery(command);
        }

        public bool UpdateCourse(Course c)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"UPDATE Course SET staff_id = {c.TutorID}, courseName = '{c.CourseName}', description = '{c.Description}', durationMins = '{c.Duration}', capacity = '{c.Capacity}', costPN = '{c.Price}', level = '{c.Level}' WHERE course_id = {c.CourseID}");

            return ExecuteNonQuery(command);
        }

        /*public int CountPods(string type)
        {
            //Set SQL query command text to valid insert statement using values from the Guest class.
            string query = ($"SELECT COUNT(*) FROM Course WHERE Type = '{type}'");

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Type", type);
                    return (int)command.ExecuteScalar();
                }
            }
        }*/

        public DataTable GetAvailableCourses(DateTime start, DateTime end)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format($"SELECT course_id AS course_id, courseName AS 'Course Name', description AS Description, durationMins AS 'Duration (Mins)', capacity AS Capacity, costPN AS 'Price', level AS Level FROM Course WHERE course_id NOT IN( SELECT course_id FROM CourseDiary WHERE(startDate <= '{start.ToString("yyyy-MM-dd")}' AND endDate >= '{start.ToString("yyyy-MM-dd")}') OR(startDate < '{end.ToString("yyyy-MM-dd")}' AND endDate >= '{end.ToString("yyyy-MM-dd")}') OR ('{start.ToString("yyyy-MM-dd")}' <= startDate AND '{end.ToString("yyyy-MM-dd")}' >= startDate) ); ");
            return RunSelectQueryOnTable(command);
        }

        public Course[] SearchCourses(string search)
        {
            Course[] allCourses = new Course[100];
            Course[] courses;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Course WHERE courseName LIKE '%{search}%' OR staff_id LIKE '{search}' OR course_id LIKE '{search}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            allCourses[i] = new Course(int.Parse(String.Format($"{reader[0]}")), int.Parse(String.Format($"{reader[1]}")), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), int.Parse(String.Format($"{reader[4]}")), int.Parse(String.Format($"{reader[5]}")), double.Parse(String.Format($"{reader[6]}")), int.Parse(String.Format($"{reader[7]}")));
                            i++;
                        }

                        //Check for duplicates in allGuests
                        allCourses = allCourses.Distinct().ToArray();
                        
                        courses = new Course[i];
                        for (int l = 0; l < courses.Length; l++)
                        {
                            courses[l] = allCourses[l];
                        }
                    }
                }
            }

            return courses;
        }

        public bool CoursePod(Course c)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"UPDATE Course SET courseName = '{c.CourseName}', description = '{c.Description}', durationMins = '{c.Duration}', capacity = '{c.Capacity}', costPN = '{c.Price}', level = '{c.Level}' WHERE course_id = {c.CourseID}");

            return ExecuteNonQuery(command);
        }

        public Course CourseLookup(int id)
        {
            Course result = new Course();

            //Get the guest corresponding to the guest_id
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Course WHERE course_id = {id}", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new Course(int.Parse(String.Format($"{reader[0]}")), int.Parse(String.Format($"{reader[1]}")), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), int.Parse(String.Format($"{reader[4]}")), int.Parse(String.Format($"{reader[5]}")), double.Parse(String.Format($"{reader[6]}")), int.Parse(String.Format($"{reader[7]}")));
                        }
                    }
                }
            }

            return result;
        }

        public Course GetCoursesFromGuest(Booking b, Guest g)
        {
            Course course = new Course();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand($"SELECT Course.* FROM Course JOIN GuestCourseBooking ON Course.course_id = GuestCourseBooking.course_id WHERE GuestCourseBooking.guest_id = '{g.GuestID}' AND GuestCourseBooking.booking_id = '{b.BookingID}'", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                course = new Course(int.Parse(String.Format($"{reader[0]}")), int.Parse(String.Format($"{reader[1]}")), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), int.Parse(String.Format($"{reader[4]}")), int.Parse(String.Format($"{reader[5]}")), double.Parse(String.Format($"{reader[6]}")), int.Parse(String.Format($"{reader[7]}")));
                                i++;
                            }
                        }
                    }
                }
                catch
                {
                    return new Course();
                }
            }

            return course;
        }
    }
}
