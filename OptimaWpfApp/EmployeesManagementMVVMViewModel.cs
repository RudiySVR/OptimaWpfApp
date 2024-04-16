using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace OptimaWpfApp
{
    class EmployeesManagementMVVMViewModel : Notifier
    {
        #region Input and output properties

        Employee _currentEmployee;
        public Employee CurrentEmployee
        {
            get
            {
                if (_currentEmployee == null)
                    _currentEmployee = new Employee();
                return _currentEmployee;
            }
            set
            {
                _currentEmployee = value;
                OnPropertyChanged("CurrentEmployee");
            }
        }
        private Employee employeeAdd;

        public Employee EmployeeAdd
        {
            get { return employeeAdd; }
            set
            {
                employeeAdd = value;
                base.OnPropertyChanged("EmployeeAdd");
                OnEmployeeAddChanged();
            }
        }

        private string searchInput;

        public string SearchInput
        {
            get { return searchInput; }
            set
            {
                searchInput = value;
                base.OnPropertyChanged("SearchInput");
                OnSearchInputChanged();
            }
        }

        private IEnumerable<Employee> foundEmployees;

        public IEnumerable<Employee> FoundEmployees
        {
            get { return foundEmployees; }
            set
            {
                foundEmployees = value;
                OnPropertyChanged("FoundEmployees");
            }
        }


        private Employee selectedEmployee;

        public Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set
            {
                selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        #endregion

        EmployeesFactory factory = new EmployeesFactory();

        public EmployeesManagementMVVMViewModel()
        {
            // Необов’язково: ми просто перевіряємо, чи список порожній.
            FoundEmployees = factory.GetAllEmployees();
        }

        private void OnSearchInputChanged()
        {
            // Необов’язково: просто переконайтеся,
            // що будь-який вибраний продукт не вибраний
            SelectedEmployee = null;

            FoundEmployees = factory.FindEmployees(SearchInput);
        }

        private void OnEmployeeAddChanged()
        {
            MessageBox.Show("Hi!");
            //throw new NotImplementedException();
        }

        RelayCommand _addEmployeeCommand;
        public ICommand AddEmployee
        {
            get
            {
                if (_addEmployeeCommand == null)
                    _addEmployeeCommand = new RelayCommand(ExecuteAddClientCommand, CanExecuteAddClientCommand);
                return _addEmployeeCommand;
            }
        }

        public void ExecuteAddClientCommand(object parameter)
        {
            if (MessageBox.Show("Додати нового співробітника?",
                      "Прийом на роботу", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CurrentEmployee.StartDate = DateTime.Now;
                EmployeesFactory employeesFactory = new EmployeesFactory();
                employeesFactory.Add(CurrentEmployee);
            }
            CurrentEmployee = null;
        }

        public bool CanExecuteAddClientCommand(object parameter)
        {
            if (string.IsNullOrEmpty(CurrentEmployee.FirstName) ||
                string.IsNullOrEmpty(CurrentEmployee.LastName) ||
                string.IsNullOrEmpty(CurrentEmployee.TabNumber))
                return false;
            return true;
        }

        //protected override void OnDispose()
        //{
        //    this.Clients.Clear();
        //}
    }
}
