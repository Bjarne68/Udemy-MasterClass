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

namespace StacksDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            string nummer1 = stack.Peek().ToString();
            MessageBox.Show($"Det översta numret i stacken är {nummer1}");
            stack.Push(2);
            string nummer2 = stack.Peek().ToString();
            MessageBox.Show($"Det översta numret i stacken är {nummer2}");
            stack.Push(3);
            string nummer3 = stack.Peek().ToString();
            int myStackItem = stack.Pop();
            MessageBox.Show($"nytt nummer {myStackItem}");
            string nummer4= stack.Peek().ToString();
            MessageBox.Show($"Det översta namnet är nu {nummer4}");

            while (stack.Count > 0)
            {
               MessageBox.Show($"numret som togs bort är{stack.Pop().ToString()}");
            }

            MessageBox.Show(stack.Count.ToString());

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            foreach (int number in numbers)
            {
                MessageBox.Show(number.ToString());
            }
            Stack<int> myStack = new Stack<int>();

            for (int i = numbers.Length; i > 0; i--)
            {
               
                stack.Push(numbers[i-1]);
                string nummer = stack.Peek().ToString();
                MessageBox.Show(nummer);
            }
        }
    }
}
