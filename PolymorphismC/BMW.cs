using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismC
{
    class BMW:Car
    {
        private string _brand = "BMW";
        public string Model { get; set; }
       
        public BMW(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }
        public sealed override void ShowDetails()
        {
            MessageBox.Show($" Märke {_brand} HP {HP} och färg {Color}");
        }

        public override void Repair()
        {
            MessageBox.Show($"BMW av modell {Model} reparerades");
        }
    }
}
