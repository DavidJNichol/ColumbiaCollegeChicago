using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermPractice
{
    public class Student : AcademicPerson
    {
        public string StudentID;
        public Pencil myPencil;
        

        public Student() : this("Bruno", "de Mello")
        {
            this.Courses = new List<Course>();
        }

        public Student(string newFirstName, string newLastName, string newStudentID ) : base(newFirstName, newLastName)
        {
            this.StudentID = newStudentID;
            this.FirstName = newFirstName;
            this.LastName = newLastName;
        }

        public Student(string newFirstName, string newLastName) : base(newFirstName, newLastName)
        {

        }

        public string Write(Pencil p, string whatToWrite)
        {
            return $"{this.FirstName} writes with {p.Write(whatToWrite)}";
        }

        public override string About()
        {
            string Person = base.About();
            Person += $" StudentID: {this.StudentID}";
            Person += $"\n{getStringListCourses()}";

            return Person;

        }


    }
}