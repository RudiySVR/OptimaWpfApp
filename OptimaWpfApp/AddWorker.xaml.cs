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

namespace OptimaWpfApp
{
    /// <summary>
    /// Логика взаимодействия для AddWorker.xaml
    /// </summary>
    public partial class AddWorker : Page
    {
        public AddWorker()
        {
            InitializeComponent();
        }
        void OnClick2(object sender, RoutedEventArgs e)
        {
            EmployeesFactory employeesFactory = new EmployeesFactory();
            employeesFactory.Add(new Employee()
            {
                Id = 1,
                TabNumber = "0248",
                FirstName = "Інший",
                LastName = "Сірий",
                SoName = "",
                Salary = 130.25M,
                Adress = "",
                Phone = "",
                JobTitle = "",
                Birthday = new DateTime(1999, 7, 20),
                StartDate = new DateTime(2015, 7, 4),
                EndDate = new DateTime(2017, 7, 4),
                Fired = true
            });

            NavigationService.GoBack();
        }
    }
}
