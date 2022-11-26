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

namespace _2DArray
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

            foreach (int item in matrix)
            {
                MessageBox.Show($"{item}");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                    MessageBox.Show($"{matrix[i, j]}");
                }
            }

        }
        static int[,] matrix =
        {
            { 1, 2, 3},
            { 4, 5, 6},
            { 7, 8, 9},
        };
        
        }
    }

