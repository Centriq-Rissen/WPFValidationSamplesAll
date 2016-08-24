using BusinessObjects.BaseClasses;
using BusinessObjects.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Validators
{
    public class EmployeeValidator2 : Validator<Employee>
    {
        public override void ValidateProperty(string propertyName, Employee obj)
        {
            RemoveError(propertyName);
            switch (propertyName)
            {
                case "FirstName":
                    ValidateFirstName(obj);
                    break;
                case "LastName":
                    ValidateLastName(obj);
                    break;
                default:
                    break;
            }
        }

        private void ValidateLastName(Employee obj)
        {
            if (obj.LastName != null && obj.LastName.Length > 20)
            {
                AddError("LastName", "Last name cannot be longer than 20 characters");
            }
        }
        private void ValidateFirstName(Employee obj)
        {
            if (obj.FirstName != null && obj.FirstName.Length > 20)
            {
                AddError("FirstName", "First name cannot be longer than 20 characters");
            }
        }
    }

}
