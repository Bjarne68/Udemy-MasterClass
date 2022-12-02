using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HashTableChallenge
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public Student(int id, string name, double gpa)
        {
            Name = name;
            Id = id;
            GPA = gpa;

        }
    }
}
    
