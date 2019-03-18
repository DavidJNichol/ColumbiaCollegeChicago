using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermPractice
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;

        public Person() : this("Angelo", "de Mello")
        {

        }

        public Person(string newFirstName, string newLastName) 
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
        }

        public virtual string About()
        {
            string s = $"{SayHello()}, My name is {this.FirstName} {this.LastName}";
            return s;
        }

        public string SayHello()
        {
            string s = "Hello";
            return s;
        }
    }
}