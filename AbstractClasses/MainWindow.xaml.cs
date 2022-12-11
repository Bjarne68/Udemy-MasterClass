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

namespace AbstractClasses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Shape[] shapes = { new Klot(4), new Cube(3) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                MessageBox.Show($"{shape.Name} har en volym av {shape.Volume().ToString()}");

                Cube iceCube = shape as Cube;
                if ( iceCube == null )
                {
                    MessageBox.Show("Det här formen är ingen kub");
                }

                if (shape is Cube)
                {
                    MessageBox.Show("Den här har formen av en kub");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                MessageBox.Show($"{cube2.Name} har en volym av {cube2.Volume()} cm3");
            }

           
        }
    }
}
