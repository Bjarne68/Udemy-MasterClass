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

namespace StructC
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void Display()
        {
            MessageBox.Show($"Spelets namn är: {name}");
            MessageBox.Show($"Spelets utvecklare är: {developer}");
            MessageBox.Show($"Spelets betyg är: {rating}");
            MessageBox.Show($"Spelets utgivningsdag är: {releaseDate}");
        }

    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01/07/2016";

            game1.Display();
        }
    }
}
