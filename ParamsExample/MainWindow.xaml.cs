using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

namespace ParamsExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMetod();
            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '$');

        }

        private static void ParamsMetod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                MessageBox.Show(sentence[i]);
            }
        }

        private static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.WriteLine(obj);
               
            }
        }
    }
}
