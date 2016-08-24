using BusinessObjects.BusinessEntities;
using BusinessObjects.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BaseClasses
{
    public class EmployeeValidatorFactory
    {
        private static EmployeeValidatorFactory _Instance;
        private EmployeeValidatorFactory() { }
        public static EmployeeValidatorFactory Current
        {
            get
            {
                if (_Instance == null)
                    _Instance = new EmployeeValidatorFactory();

                return _Instance;
            }
        }
        public Validator<Employee> GetValidator()
        {
            return new EmployeeValidator1();
        }
    }
}
