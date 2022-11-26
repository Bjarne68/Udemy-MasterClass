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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Udemy_MasterClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnValue_Click(object sender, RoutedEventArgs e)
        {
           

            
    }

        private void btnChoice_Click(object sender, RoutedEventArgs e)
        {
            string inputValue = txtValue.Text;
            System.Boolean valid = false;
            int inputType = int.Parse(txtChoice.Text);

            
            string inputValueType;
            switch (inputType)
            {
                case 1:
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Number";
                    break;
                case 3:
                    bool retFlag = false;
                    valid = System.Boolean.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "unknown";
                    MessageBox.Show("Not able to detect input type, something is wrong");
                    break;



            }
            MessageBox.Show($"You have entered a {inputValueType}");
            if (valid)
            {
                MessageBox.Show($"It is valid {inputValueType}");
                MessageBox.Show($"It is an invalid {inputValueType}");
            }
        }

        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
    }
