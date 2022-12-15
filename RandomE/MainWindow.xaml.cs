using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace RandomE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random dice = new Random();
            //int numEyes;

            //for (int i = 0; i < 10; i++)
            //{
            //    numEyes = dice.Next(1, 7);
            //    MessageBox.Show(numEyes.ToString());
            //}


            for (int i = 0; i < 6; i++)
            {
                int nummer = dice.Next(1, 4);
                {
                    string svar = nummer switch
                    {
                        1 => "Ja",

                        2 => "Kanske",
                        3 => "Nej",
                        _ => throw new NotImplementedException()
                    };
                    MessageBox.Show(svar.ToString());
                }
                //    switch (nummer)
                //    {
                //        case 1:
                //            MessageBox.Show("Ja");
                //            break;
                //        case 2:
                //            MessageBox.Show("Kanske");
                //            break;
                //        case 3:
                //            MessageBox.Show("Nej");
                //            break;
                //    }
                //}

            }
        }
    }
}
