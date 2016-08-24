using BusinessObjects.BaseClasses;
using BusinessObjects.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BusinessEntities
{
    public class Employee : IDataErrorInfo, INotifyPropertyChanged
    {
        Validator<Employee> _Val;

        public Employee()
        {
            _Val = new EmployeeValidator1();
        }
        public Employee(Validator<Employee> validator)
        {
            _Val = validator;
        }
        private int _ID;
        private string _FirstName;
        private string _LastName;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                _Val.ValidateProperty("FirstName", this);
                RaisePropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                _Val.ValidateProperty("LastName", this);
                RaisePropertyChanged("LastName");
            }
        }

        public string Error
        {
            get { return string.Empty; }
        }

        public string this[string columnName]
        {
            get { return _Val[columnName]; }
        }

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
