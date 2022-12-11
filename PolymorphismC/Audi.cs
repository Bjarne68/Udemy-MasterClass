using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismC
{
    public class Audi:Car
    {
        private string _brand = "Audi";
        public string Model { get; set; }
        public Audi(int hp, string color, string model):base(hp, color)
        {
            Model = model;
        }
        public override void ShowDetails()
        {
            MessageBox.Show($" Märke {_brand} HP {HP} och färg {Color}");
        }

        public override void Repair()
        {
            MessageBox.Show($"Audi av modell {Model} reparerades");
        }

    }
}
