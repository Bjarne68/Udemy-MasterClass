using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AbstractClasses
{
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            MessageBox.Show($"Det här är en {Name}");
        }

        public abstract double Volume();
       
    }
}
