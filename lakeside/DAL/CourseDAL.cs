using lakeside.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
