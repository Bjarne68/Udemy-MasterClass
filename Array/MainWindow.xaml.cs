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

namespace Array
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[,] matrix;

            int[,,] threeD;

            string[,,] array3D = new string[,,]
            {
                {
                    { "000", "001"},
                    {"010", "011" },
                    {"Hi there", "Whats up" }
                },

                {
                { "100", "101"},
                { "110", "111"},
                { "Another one", "Last entry"}
                 }
            };

            MessageBox.Show($"The value is {array3D[1,2,1]}");

            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };
            array2DString[1, 1] = "chicken";
            MessageBox.Show($"talet är {array2DString[1,1]}");

            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };
            MessageBox.Show($"The value is {dimensions}");
        }
    }
        
    }
