using System;
using System.Collections;
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


namespace ArrayLista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ArrayList myArrayList = new ArrayList();
            var myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(138);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            myArrayList.Remove(13);
            myArrayList.Remove(13);
            myArrayList.Remove(13);
            myArrayList.RemoveAt(0);

            MessageBox.Show($"{myArrayList.Count.ToString()}");

            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    MessageBox.Show($"{obj}");
                }
            }
            MessageBox.Show(sum.ToString());
        }
    }
}
