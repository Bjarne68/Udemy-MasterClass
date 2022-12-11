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
using System.IO;

namespace FileIO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Method 1
            string[] lines = { "First 250", "Second 242", "Third 240" };

            //File.WriteAllLines(@"F:\C# Masterclass Course\Projects\Assets\highscores.txt", lines);
            /*
            // Method 2
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"F:\C# Masterclass Course\Projects\Assets\" + fileName + ".txt", input);
            */
            // Method 3
            using (StreamWriter file = new StreamWriter(@"C:\Users\bjarn\OneDrive\Dokument\myText2.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\bjarn\OneDrive\Dokument\myText2.txt", true))
            {
                file.WriteLine("Additional line");
            }

            /*
             * // Example 1 - reading Text
            string text = System.IO.File.ReadAllText(@"F:\C# Masterclass Course\Projects\Assets\textFile.txt");

            Console.WriteLine("Textfile contains following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"F:\C# Masterclass Course\Projects\Assets\textFile.txt");

            Console.WriteLine("Contents of textfile.txt = ");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */
            Console.ReadKey();


        }

    }

        //private void btnInput_Click(object sender, RoutedEventArgs e)
        //{
        //    string fileName = txtFileName.Text;
        //    string input = txtInput.Text;

        //    File.WriteAllText(@"C:\Users\bjarn\OneDrive\Dokument\" + fileName + ".txt", input);
        //}

        

        
}
