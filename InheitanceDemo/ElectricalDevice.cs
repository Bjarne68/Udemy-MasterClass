using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheitanceDemo
{
    public class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public void SwitchOn() { IsOn = true; }
        public void SwitchOff() { IsOn = false; }
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }
    }
}
