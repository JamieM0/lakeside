using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lakeside.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public int TutorID { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public int Level { get; set; }

        public Course()
        {
            CourseID = 0;
            TutorID = 0;
            CourseName = "";
            Description = "";
            Duration = 0;
            Capacity = 0;
            Price = 0;
            Level = 0;
        }

        public Course(int courseID, int tutorID, string courseName, string description, int duration, int capacity, double price, int level)
        {
            CourseID = courseID;
            TutorID = tutorID;
            CourseName = courseName;
            Description = description;
            Duration = duration;
            Capacity = capacity;
            Price = price;
            Level = level;
        }
    }
}
