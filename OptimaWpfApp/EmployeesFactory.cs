﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimaWpfApp
{
    class EmployeesFactory
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public IEnumerable<Employee> FindEmployees(string searchString)
        {
            return employees.Where(p => p.LastName.Contains(searchString));
            //return employees.Where(p => p.TabNumber.Contains(searchString) || p.LastName.Contains(searchString));
        }

        #region In-memory data
        // Цей код створює колекцію співробітників у пам’яті
        // але ми також могли б отримати його з бази даних
        // або веб-сервіса, і це дасть той самий результат.
        static IList<Employee> employees;
        static EmployeesFactory()
        {
            employees = new List<Employee>();
            employees.Add(new Employee()
            {
                Id = 1,
                TabNumber = "0248",
                FirstName = "Петро",
                LastName = "Сірий",
                SoName = "",
                Salary = 130.25M,
                Adress = "",
                Phone = "",
                JobTitle = "",
                Birthday = new DateTime(1999, 7, 20),
                StartDate = new DateTime(2015, 7, 4),
                //EndDate = DateTime.Now
            });
            employees.Add(new Employee()
            {
                Id = 2,
                TabNumber = "0278",
                FirstName = "Петро",
                LastName = "Рябий",
                SoName = "",
                Salary = 130.25M,
                Adress = "",
                Phone = "",
                JobTitle = "",
                Birthday = DateTime.Now,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            });
            employees.Add(new Employee()
            {
                Id = 3,
                TabNumber = "0249",
                FirstName = "Tom",
                LastName = "Ronald",
                SoName = "",
                Salary = 130.25M,
                Adress = "",
                Phone = "",
                JobTitle = "",
                Birthday = DateTime.Now,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            });
            employees.Add(new Employee()
            {
                Id = 4,
                TabNumber = "0348",
                FirstName = "Jane",
                LastName = "Roe",
                SoName = "",
                Salary = 130.25M,
                Adress = "",
                Phone = "",
                JobTitle = "",
                Birthday = DateTime.Now,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            });
            //employees.Add(new Employee("Петро", "Рябий"));
            //employees.Add(new Employee("Tom", "Ronald"));
            //employees.Add(new Employee("Jane", "Roe"));
        }
        #endregion
    }
}
