using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace DelegatesDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate bool FilterDelegate(Person p);
        public MainWindow()
        {
            InitializeComponent();
       
            

            Person p1 = new Person() { Name="Aiden", Age=41};
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1,p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adult", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age > 20 && p.Age < 30;
            };

            DisplayPeople("Mellan 20 och 30:", people, filter);
            DisplayPeople("Alla:", people, delegate (Person p) { return true; });

            string searchKeyword = "A";
            DisplayPeople("age > 20 with search keyword:"  + searchKeyword, people, (p) =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            DisplayPeople("exactly 25:", people, p => p.Age == 25);
        }
         static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            MessageBox.Show(title);
            foreach (Person p in people)
            { 
                if (filter(p))
                {
                    MessageBox.Show($"{p.Name} är {p.Age} år gammal");
                }
            }
        }

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }
       
        static  bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age > 65;
        }
    }
}
