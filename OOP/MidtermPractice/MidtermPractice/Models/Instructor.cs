using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermPractice
{
    public class Instructor : AcademicPerson
    {
        public string FacultyID;

        public Instructor() : this("Benedito", "Fatal")
        {
            this.Courses = new List<Course>();
        }

        public Instructor(string newFirstName, string newLastName) : base(newFirstName, newLastName)
        {
            this.Courses = new List<Course>();
            this.FirstName = newFirstName;
            this.LastName = newLastName;
        }

        public override string About()
        {
            string Person = base.About();
            Person += $" FacultyID: {this.FacultyID}";
            Person += $"\n{getStringListCourses()}";

            return Person;
        }

        
    }
}