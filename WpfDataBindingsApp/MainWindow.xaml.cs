using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDataBindingsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Employee Employee { get; set; }
        public ObservableCollection<Employee> Employees { get; set; }

        
        public MainWindow()
        {

            //Employee = new Employee()
            //{
            //    Name = "Jimmy",
            //    Age = 28,
            //    Company = new Company() { Title = "Yandex" },
            //    Salary = 120000
            //};
            //this.Resources.Add("employee", Employee);

            InitializeComponent();

            Company yandex = new() { Title = "Yandex" };
            Company ozon = new() { Title = "Ozon" };

            Employees = new()
            {
                new Employee
                {
                    Name = "Benny",
                    Age = 26,
                    Company = yandex,
                    Salary = 130000
                },
                new Employee
                {
                    Name = "Sammy",
                    Age = 31,
                    Company = ozon,
                    Salary = 150000
                },
                new Employee
                {
                    Name = "Fanny",
                    Age = 29,
                    Company = yandex,
                    Salary = 210000
                },
            };

            Employee = new Employee()
            {
                Name = "Jimmy",
                Age = 28,
                Company = new Company() { Title = "Yandex" },
                Salary = 120000
            };


            //this.DataContext = Employees;
            listEmployees.ItemsSource = Employees;
            listEmployees.DisplayMemberPath = "Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employees.Add(Employee);
        }
    }
}