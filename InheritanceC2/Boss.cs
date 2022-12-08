using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceC2
{
    class Boss:Employee
    {
        public string CompanyCar { get; set; }
        public Boss()
        {

        }

        public Boss(string name, string firstName, double salary, string companyCar):base (name, firstName, salary)
        {
           
            CompanyCar= companyCar;
        }

        public void Lead()
        {
            MessageBox.Show($"I'm boss! My name is {FirstName} {Name}");
        }

    }
}
