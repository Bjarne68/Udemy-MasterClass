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

namespace NullablesE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            MessageBox.Show($"Våra nullable nummer är: {num1} {num2} {num3} {num4}");
            MessageBox.Show($"Den nullable bool är: {boolval}");

            bool? isMale = null;
            if(isMale == true)
            {
                MessageBox.Show("Användaren är en man");
            }
            else if(isMale == false)
            {
                MessageBox.Show("Användaren är kvinna");
            }
            else
            {
                MessageBox.Show("Inget kön valt");
            }

            double? num5 = 13.1;
            double? num6 = null;
            double num7;

            if (num5 == null)
            {
                num7 = 0.0;
            }
            else
            {
                num7 = (double)num5;
            }

            MessageBox.Show($"Värdet av num7 är: {num7}");
            num7 = num5 ?? 8.53;
            MessageBox.Show(num7.ToString());
            num7 = num6 ?? 8.53;
            MessageBox.Show(num7.ToString());
        }
    }
}
