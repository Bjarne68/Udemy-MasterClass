using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

namespace DateTimeE
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        DateTime now = DateTime.Now;
        public MainWindow()
        {
            
            InitializeComponent();

            DateTime dateTime = new DateTime(1968, 10, 21);
            MessageBox.Show(dateTime.ToString());
            MessageBox.Show(DateTime.Today.ToString());
            MessageBox.Show(DateTime.Now.ToString());

            DateTime tomorrow = GetTomorrow();
            MessageBox.Show($"Imorgon är det: {tomorrow}");

            MessageBox.Show(DateTime.Today.DayOfWeek.ToString());
            MessageBox.Show(GetFirstDayOfYear(1999).ToString());

            int days = DateTime.DaysInMonth(2000, 2);
            MessageBox.Show(days.ToString());
            days = DateTime.DaysInMonth(2001, 2);
            MessageBox.Show(days.ToString());
            days = DateTime.DaysInMonth(2004, 2);
            MessageBox.Show(days.ToString());
            days = DateTime.DaysInMonth(1968, 2);
            MessageBox.Show(days.ToString());

           
            MessageBox.Show(now.Minute.ToString());

            MessageBox.Show($" Klockan är: {now.Hour.ToString()} {now.Minute.ToString()} {now.Second.ToString()}");
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            if(DateTime.TryParse(input, out DateTime dateTime)) 
            {
                MessageBox.Show(dateTime.ToString());
                TimeSpan daysPassed = now.Subtract(dateTime);
                MessageBox.Show($"Dagar som gått sedan: {daysPassed.Days.ToString()}");
            }
            else
            {
                MessageBox.Show("Felaktig inmatning");
            }
        }
    }
}
