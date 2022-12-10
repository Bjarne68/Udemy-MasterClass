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

namespace InumerableDemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<int> numberList = new List<int>() { 8, 6, 2 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };

            CollectionSum(numberList);

            CollectionSum(numberArray);

        }
        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;
            foreach (var item in anyCollection)
            {
                sum += item;
            }

            MessageBox.Show($"Summan är {sum}");
        }
    }
}
