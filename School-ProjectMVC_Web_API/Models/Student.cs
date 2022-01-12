using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_ProjectMVC_Web_API.Models
{
    public class Student
    {
        public int Id; 
        public string FirstName;
        public string LastName;
        public string Grade;
        public int Age;

        public Student(int id, string firstName, string lastName, string grade, int age)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Age = age;
        }
        
    }
}