using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    internal class Employee : INotifyPropertyChanged
    {

        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        private string _department;
        private decimal _salary;
        private string _dateOfBirth;
        private DateTime _joiningDate;

        public int EmployeeID
        {
            get => _employeeID;
            set { _employeeID = value; OnPropertyChanged(nameof(EmployeeID)); }
        }

        public string FirstName
        {
            get => _firstName;
            set { _firstName = value; OnPropertyChanged(nameof(FirstName)); }
        }

        public string LastName
        {
            get => _lastName;
            set { _lastName = value; OnPropertyChanged(nameof(LastName)); }
        }

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        public string Phone
        {
            get => _phone;
            set { _phone = value; OnPropertyChanged(nameof(Phone)); }
        }

        public string Department
        {
            get => _department;
            set { _department = value; OnPropertyChanged(nameof(Department)); }
        }

        public decimal Salary
        {
            get => _salary;
            set { _salary = value; OnPropertyChanged(nameof(Salary)); }
        }

        public DateTime JoiningDate
        {
            get => _joiningDate;
            set { _joiningDate = value; OnPropertyChanged(nameof(JoiningDate)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
