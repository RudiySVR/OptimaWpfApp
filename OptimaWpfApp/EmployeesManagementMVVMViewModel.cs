using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimaWpfApp
{
    class EmployeesManagementMVVMViewModel : Notifier
    {
        #region Input and output properties

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

        private IEnumerable<Employee> foundProducts;

        public IEnumerable<Employee> FoundProducts
        {
            get { return foundProducts; }
            set
            {
                foundProducts = value;
                OnPropertyChanged("FoundProducts");
            }
        }


        private Employee selectedProduct;

        public Employee SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }

        #endregion

        EmployeesFactory factory = new EmployeesFactory();

        public EmployeesManagementMVVMViewModel()
        {
            // Необов’язково: ми просто перевіряємо, чи список порожній.
            FoundProducts = factory.GetAllEmployees();
            //FoundProducts = Enumerable.Empty<Employee>();
        }

        private void OnSearchInputChanged()
        {
            // Необов’язково: просто переконайтеся,
            // що будь-який вибраний продукт не вибраний
            SelectedProduct = null;

            FoundProducts = factory.FindEmployees(SearchInput);
        }
    }
}
