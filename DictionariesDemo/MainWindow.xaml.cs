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

namespace DictionariesDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artosias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8)

            };

            Dictionary<string, Employee> employeesDictionary = new Dictionary<string, Employee>();
            foreach (Employee employee in employees)
            {
                employeesDictionary.Add(employee.Role, employee);
            }

            string KeyToUpdate = "HR";
            if (employeesDictionary.ContainsKey(KeyToUpdate))
            {
                employeesDictionary[KeyToUpdate] = new Employee("HR", "Erika", 26, 18);
                MessageBox.Show($"Den anställde med Roll/key {KeyToUpdate} uppdaterades");
            }
            else
            {
                MessageBox.Show($"Det fanns ingen med Roll {KeyToUpdate}");
            }

            string KeyToRemove = "Intern";
            if (employeesDictionary.Remove(KeyToRemove))
            {
                MessageBox.Show($"Den anställde med Roll/key {KeyToUpdate} togs bort");
            }

            string key = "CEO";
            if(employeesDictionary.ContainsKey(key))
            {
                Employee empl = employeesDictionary[key];
                MessageBox.Show($"Employee Name: {empl.Name} Role: {empl.Role} Salary: {empl.Salary}");
            }
            else
            {
                MessageBox.Show("Det fanns ingen anställd med det värdet");
            }

            

            Employee result = null;

            if(employeesDictionary.TryGetValue("Intern", out result))
            {
                MessageBox.Show("Value retrieved!.");
                MessageBox.Show($"Employee Name: {result.Name}");
                MessageBox.Show($"Employee Role: {result.Role}");
                MessageBox.Show($"Employee Age: {result.Age}");
                MessageBox.Show($"Employee Salary: {result.Salary}");
            }
            else
            {
                MessageBox.Show("The key does not exsist");
            }

            for (int i = 0; i < employeesDictionary.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDictionary.ElementAt(i);

                MessageBox.Show($"Key: {keyValuePair.Key}");
                Employee employeeValue = keyValuePair.Value;

                MessageBox.Show($"Employee Name: {employeeValue.Name}");
                MessageBox.Show($"Employee Role: {employeeValue.Role}");
                MessageBox.Show($"Employee Name: {employeeValue.Age}");
                MessageBox.Show($"Employee Name: {employeeValue.Salary}");
            }
           

            Dictionary<int, string> myDictionary = new Dictionary<int, string>() {
                { 1, "one"},
                { 2, "two"},
                { 3 , "three"} };

        }
    }
}
