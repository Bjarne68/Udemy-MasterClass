using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheitanceDemo
{
    public class Radio:ElectricalDevice
    {
        

        public Radio(bool isOn, string brand):base(isOn, brand)
        {
            
        }
        
        public void ListenRadio()
        {
            if (IsOn) { MessageBox.Show("Listening to the Radio!"); }
            else
            {
                MessageBox.Show("Radio is switched off, switch it on first");
            }
        }
            
    }
}
