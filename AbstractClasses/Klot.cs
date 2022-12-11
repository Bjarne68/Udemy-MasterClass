using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AbstractClasses
{
    class Klot : Shape
    {
        public double Radie { get; set; }
        public Klot(double radie)
        {
            Name = "Sfär";
            Radie = radie;
        }
        public override double Volume()
        {
            return 4 * Math.PI * Math.Pow(Radie, 3) / 3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            MessageBox.Show($"Klotet har en radie av {Radie} cm");
        }
    }
}
