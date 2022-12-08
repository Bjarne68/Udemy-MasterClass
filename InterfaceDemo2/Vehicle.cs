using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Vehicle
    {
        public double Speed { get; set; }
        public string Color { get; set; }

        public Vehicle(double speed, string color)
        {
            Speed = 120;
            Color = "White";
        }
    }
}
