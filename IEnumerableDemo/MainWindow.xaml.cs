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

namespace IEnumerableDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            MessageBox.Show("This was a List<int>");

            foreach (int num in unknownCollection)
            {
                MessageBox.Show($"{num}");
            }

            unknownCollection= GetCollection(2);
            MessageBox.Show("This was a Queue<int>");

            foreach (int num in unknownCollection)
            {
                MessageBox.Show($"{num}");
            }

            unknownCollection = GetCollection(5);
            MessageBox.Show("This was array of int");

            foreach (int num in unknownCollection)
            {
                MessageBox.Show($"{num}");
            }
        }
        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>() {1,2,3,4,5};

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if(option == 1)
            {
                return numbersList;
            }
            if(option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15, };
            }
            
        }
    }
}
