using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceC2
{
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string firstName, double salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }
         
        public virtual void Work()
        {
                MessageBox.Show("I'm working");
        }

        public void Pause()
        {
                MessageBox.Show("I'm having a break");
        }
    }
}
