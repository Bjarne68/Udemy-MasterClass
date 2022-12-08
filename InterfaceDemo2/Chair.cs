using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfaceDemo2
{
    class Chair:Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string color, string material)
        {
            Color=color;
            Material = material;

            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            MessageBox.Show($"The {Color} chair was destroyed");
            MessageBox.Show($"Playing destruction sound {DestructionSound}");
            MessageBox.Show("Spawning chair parts");
        }
    }
}
