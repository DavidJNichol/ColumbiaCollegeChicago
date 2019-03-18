using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Course oop = new Course();
            Course oop2 = new Course() { CourseName = "OOP 2", CourseNumber = "PROG200" };
            Course bio = new Course() { CourseName = "Biology of AIDS", CourseNumber = "BIO100" }; ;
            
            
            
            Console.WriteLine(oop.About());
            Console.WriteLine(oop2.About());
            Console.WriteLine(bio.About());

            AcademicPerson p = new AcademicPerson();
            p.FirstName = "Angelo";
            p.LastName = "Casagrande";
            Console.WriteLine(p.About());

            Instructor valdez = new Instructor();
            valdez.FirstName = "Valdez";
            valdez.LastName = "Limpo";
            valdez.FacultyID = "123";
            valdez.AddCourse(oop);
            valdez.AddCourse(new Course() { CourseName = "OOP2", CourseNumber = "PROG200" });
            Console.WriteLine(valdez.About());

            Pencil pen = new Pencil();
            Console.WriteLine(pen.About());

            Student rafa = new Student();
            rafa.FirstName = "Rafael";
            rafa.LastName = "Medeiros";
            rafa.StudentID = "666";
            rafa.AddCourse(oop);
            rafa.AddCourse(oop2);
            Console.WriteLine(rafa.About());
            rafa.DropCourse(oop);

            Console.WriteLine(rafa.SayHello()); 

            Console.ReadKey();

        }
    }
}
