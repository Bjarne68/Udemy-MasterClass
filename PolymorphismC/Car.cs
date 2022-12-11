using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismC
{
    public class Car
    {
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetIDInfo(int idNum, string ägare)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Ägare = ägare;
        }

        public void GetCarIDInfo()
        {
            MessageBox.Show($"Bilen har ID nummer {carIDInfo.IDNum} och ägs av {carIDInfo.Ägare}");
        }
        public int HP { get; set; }
        public string Color { get; set; }

        
        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;
        }
        public virtual void ShowDetails()
        {
            MessageBox.Show($"HP {HP} och färg {Color}");
        }
        public virtual void Repair()
        {
            MessageBox.Show("Bilen reparerades");
        }
    }
}
