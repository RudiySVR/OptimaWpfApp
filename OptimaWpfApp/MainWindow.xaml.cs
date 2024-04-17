using OptimaWpfApp.Sevices;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Import_Click(object sender, RoutedEventArgs e)
        {
            EmployeesFactory employees = new EmployeesFactory();
            FileInfo fileInfo = new FileInfo(@"workers.json");
            if (fileInfo.Exists)
            {
                employees.Import();
                EmployeesManagementMVVM employeesManagementMVVM = new EmployeesManagementMVVM();
            }
            else
            {
                MessageBox.Show("Файл workers.json не існує.");
            }
        }
        void Export_Click(object sender, RoutedEventArgs e)
        {
            WorkerManipulation workerManipulation = new WorkerManipulation();
            EmployeesFactory employees = new EmployeesFactory();
            workerManipulation.WriteJson(employees.GetAllEmployees());
        }
        void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
