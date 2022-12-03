using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QueueDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in RecieveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while(ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }


            static Order[] RecieveOrdersFromBranch1()
            {
                Order[] orders = new Order[]
                {
                    new Order(1,5),
                    new Order(2,4),
                    new Order(6,10),
                };
                return orders;
            }
            
            static Order[] RecieveOrdersFromBranch2()
            {
                Order[] orders = new Order[]
                {
                    new Order(3,5),
                    new Order(4,4),
                    new Order(5,10),
                };
                return orders;
            }
        }
    }
}
