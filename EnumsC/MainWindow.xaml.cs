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
using EnumsC.Enums;

namespace EnumsC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Day fr = Day.Fre;
            Day sö = Day.Sö;

            Day a = Day.Fre;

            //MessageBox.Show((fr == a).ToString());
            //MessageBox.Show(Day.Må.ToString());
            int num = (int)Day.Må;
            MessageBox.Show(num.ToString());

            int num2 = (int)Månad.Febr;
            MessageBox.Show(num2.ToString());

            int num3 = (int)Månad.Aug;
            MessageBox.Show(num3.ToString());
            
        }
    }
}
