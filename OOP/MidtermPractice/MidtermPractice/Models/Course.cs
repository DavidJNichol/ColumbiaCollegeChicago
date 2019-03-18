using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermPractice
{
    public class Course
    {
        public string CourseName;
        public string CourseNumber;

        public Course() : this("OOP 1", "PROG100")
        {

        }

        public Course(string newCourseName, string newCourseNumber)
        {
            this.CourseName = newCourseName;
            this.CourseNumber = newCourseName;
        }

        public string About()
        {
            string s = $"ID: {this.CourseNumber}";
            s += $" Name: {this.CourseName}";
            return s;
        }

        public virtual List<Course> AddCourse(Course c, List<Course> ca)
        {
            ca.Add(c);
            return ca;
        }

        public virtual List<Course> DropCourse(Course c, List<Course> ca)
        {
            ca.Remove(c);
            return ca;
        }
    }
}