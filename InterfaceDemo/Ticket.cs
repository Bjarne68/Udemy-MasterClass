using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Ticket:IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return DurationInHours == other.DurationInHours;
        }
    }
}
