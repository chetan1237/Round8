using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.ModelView
{
    internal class EmployeeViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeeViewModel()
        {
            Employees = new ObservableCollection<Employee>()
            {
                new Employee { EmployeeID = 1, FirstName="John", LastName="Doe", Department="HR", Salary=45000, JoiningDate=DateTime.Now },
                new Employee { EmployeeID = 2, FirstName="Sarah", LastName="Smith", Department="IT", Salary=60000, JoiningDate=DateTime.Now }
            };
        }
    }
}
