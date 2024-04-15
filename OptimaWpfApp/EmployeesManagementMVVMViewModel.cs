using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OptimaWpfApp
{
    class EmployeesManagementMVVMViewModel : Notifier
    {
        #region Input and output properties

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
    }
}
