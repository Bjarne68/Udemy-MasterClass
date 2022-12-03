using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QueueDemo
{
    public class Order
    {
        public int OrderID { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            OrderID = id;
            OrderQuantity = orderQuantity;
        }
        public void ProcessOrder()
        {
            MessageBox.Show($"Order {OrderID} was processed");
        }
    }
}
