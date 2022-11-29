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

namespace JaggedArray
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

            
            string[][] jaggedArray2 = new string[][]
            {
                new string[] {"Pelle", "Anna"},
                new string[] { "Bosse", "Göran" },
                new string[] { "Lars", "Sven"}
        };
           MessageBox.Show($"Hej {jaggedArray2[0][1]} jag heter {jaggedArray2[1][1]}");
        }
    }
}
