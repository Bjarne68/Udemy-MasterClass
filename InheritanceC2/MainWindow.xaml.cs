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

namespace InheritanceC2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Employee employee= new Employee("Andersson", "Bjarne", 40000);
            employee.Work();
            employee.Pause();

            Boss boss = new Boss("Karlsson", "Karl", 200000, "Ferrari");
            boss.Lead();

            Trainees trainees = new Trainees("Pelle", "Larsson", 1000, 30, 10);
            trainees.Work();
            trainees.Learn();
             

        }
    }
}
