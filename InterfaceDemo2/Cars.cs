using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfaceDemo2
{
    class Cars: Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearby;
        

        public Cars(double speed, string color):base(speed, color)
        {
            DestructionSound = "CarExplosion.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            MessageBox.Show($"Spelar förstörelseljud {DestructionSound}");
            MessageBox.Show("Ska eld");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
