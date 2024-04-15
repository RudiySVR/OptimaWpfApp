using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimaWpfApp
{
    public class Employee : Notifier
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        //public string TabNumber { get; set; }
        private string tabNumber;
        public string TabNumber
        {
            get { return tabNumber; }
            set
            {
                tabNumber = value;
                OnPropertyChanged("TabNumber");
            }
        }
        //public string LastName { get; set; }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        //public string FirstName { get; set; }
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        //public string SoName { get; set; }
        private string soName;
        public string SoName
        {
            get { return soName; }
            set
            {
                soName = value;
                OnPropertyChanged("SoName");
            }
        }
        //public decimal Salary { get; set; }
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                OnPropertyChanged("Salary");
            }
        }
        //public string Adress { get; set; }
        private string adress;
        public string Adress
        {
            get { return adress; }
            set
            {
                adress = value;
                OnPropertyChanged("Adress");
            }
        }
        //public string Phone { get; set; }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
        //public DateTime Birthday { get; set; }
        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
            }
        }
        //public string JobTitle { get; set; }
        private string jobTitle;
        public string JobTitle
        {
            get { return jobTitle; }
            set
            {
                jobTitle = value;
                OnPropertyChanged("JobTitle");
            }
        }
        //public DateTime StartDate { get; set; }
        private DateTime startDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                OnPropertyChanged("StartDate");
            }
        }
        //public DateTime EndDate { get; set; }
        private DateTime endDate;
        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                endDate = value;
                OnPropertyChanged("EndDate");
            }
        }
        //public DateTime EndDate { get; set; }
        private bool fired;
        public bool Fired
        {
            get { return fired; }
            set
            {
                fired = value;
                if (fired)
                {
                    endDate =  DateTime.Now;
                }
                OnPropertyChanged("Fired");
                OnPropertyChanged("EndDate");
            }
        }
        public Employee() { }
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
