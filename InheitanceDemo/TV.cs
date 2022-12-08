using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheitanceDemo
{
    public class TV:ElectricalDevice
    {

        public TV(bool isOn, string brand):base(isOn, brand)
        {
            
        }

        public void WatchTV()
        {
            if (IsOn) { MessageBox.Show($"Watch the TV!"); }
            else
            {
                MessageBox.Show("TV is switched off, switch it on first");
            }
        }
    }
}
    
