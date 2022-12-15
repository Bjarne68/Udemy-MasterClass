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

namespace MathE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show("Ceiling:" + (Math.Ceiling(15.3).ToString()));
            MessageBox.Show("Floor:" + (Math.Floor(15.3).ToString()));
            int num1 = 13;
            int num2 = 9;

            MessageBox.Show("Det minsta talet av "+ num1.ToString() + " och " + num2.ToString() + " är " + (Math.Min(num1,num2).ToString()));
            MessageBox.Show("Det högsta talet av " + num1.ToString() + " och " + num2.ToString() + " är " + (Math.Max(num1, num2).ToString()));
            MessageBox.Show("3 upphöjt till 5 är: " + (Math.Pow(3, 5)));
            MessageBox.Show("PI är: " + Math.PI.ToString());
            MessageBox.Show("Roten ur 25 är: " + Math.Sqrt(25).ToString());
            MessageBox.Show("Alltid ett positivt tal: " + Math.Abs(-999.99).ToString());
            MessageBox.Show("Cosinus av ett är: " + Math.Cos(1));
        }
    }
}
