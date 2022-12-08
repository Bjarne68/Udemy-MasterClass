using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VirtualOverrideDemo
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name= name;
            Age = age;
            IsHungry = true;
        }

        public virtual void Makesound()
        {
            MessageBox.Show($"{Name} säger ...");
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                MessageBox.Show($"{Name} is eating");
            }
            else
            {
                MessageBox.Show($"{Name} is not hungry");
            }
        }
        public virtual void Play()
        {
            MessageBox.Show($"{Name} is playing");
        }
    }
}
