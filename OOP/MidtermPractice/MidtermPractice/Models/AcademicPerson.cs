using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermPractice
{
    public class AcademicPerson : Person
    {
        public List<Course> Courses;

        public AcademicPerson() : this("Enda", "Kab")
        {
            
        }

        public AcademicPerson(string newFirstName, string newLastName) : base(newFirstName, newLastName)
        {
            this.Courses = new List<Course>();
        }

        public void AddCourse(Course c)// Association 
        {
            this.Courses.Add(c);
        }

        public void DropCourse(Course c)// Association
        {
            this.Courses.Remove(c);
        }

        public string getStringListCourses()
        {
            string s = "Courses: ";
            foreach (Course c in this.Courses)
            {
                s += Convert.ToString(c.CourseName);
                s += " ";
            }
            return s;
        }
    }
}