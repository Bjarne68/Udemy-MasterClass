using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IEnumerableAndIEnumatorDemo
{
    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog)
        {
            Name = name;
            IsNaughtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numberOfTreats)
        {
            MessageBox.Show($"The Dog: {Name} said wuuuf {numberOfTreats} times");
        }
    }
}
