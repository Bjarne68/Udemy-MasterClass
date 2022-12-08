using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceC2
{
    public class Trainees:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        public Trainees()
        {

        }

        public Trainees(string name, string firstname, double salary, int workingHours, int schoolHours):base(name, firstname, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public override void Work()
        {
            MessageBox.Show($"Jag jobbar {WorkingHours} timmar");  
        }

        public void Learn()
        {
            MessageBox.Show($"Jag studerar {SchoolHours} timmar");
        }
    }
   
}
