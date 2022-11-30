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

namespace ArrayAsParameters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int[] happyness = new int[] { 1, 89, 17, 99, 6};
            GetHappyness(happyness);

            foreach (int grade in happyness)
            {
                MessageBox.Show($"{grade}");
            }

           

            static void GetHappyness(int[] happyness)
            {
                int size= happyness.Length;
                
                for (int i = 0; i < size; i++)
                {
                    happyness[i] = happyness[i] +2;
                }
              
               
            }
        }
    }
}
