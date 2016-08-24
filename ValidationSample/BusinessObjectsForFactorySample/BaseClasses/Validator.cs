using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BaseClasses
{
    /// <summary>
    /// This class contains all the default validation logic
    /// </summary>
    /// <typeparam name="T">T is the entity type this class will be validating</typeparam>
    public abstract class Validator<T>
    {
        //  This is used to hold all the error messages by key
        private Dictionary<string, string> _Errors;

        //  Constructor - create a new Dictionary<string, string>
        public Validator()
        {
            _Errors = new Dictionary<string, string>();
        }

        /// <summary>
        /// Mechanism to Add an error condition for a property
        /// </summary>
        /// <param name="propertyName">Name of the property in error (case sensitive)</param>
        /// <param name="errorMessage">Error text to be displayed to user</param>
        public void AddError(string propertyName, string errorMessage)
        {
            if (!_Errors.ContainsKey(propertyName))
            {
                _Errors.Add(propertyName, errorMessage);
            }
        }

        /// <summary>
        /// Mechanism to remove an error condition for a property
        /// </summary>
        /// <param name="propertyName">Name of the property to be removed</param>
        public void RemoveError(string propertyName)
        {
            if (_Errors.ContainsKey(propertyName))
            {
                _Errors.Remove(propertyName);
            }
        }

        /// <summary>
        /// Mechanism to relay any error message up the chain
        /// </summary>
        /// <param name="propertyName">Name of the property to return the error message for</param>
        /// <returns>Either empty string for no errors or some error message to relay to user</returns>
        public string this[string propertyName]
        {
            get
            {
                if (_Errors.ContainsKey(propertyName))
                    return _Errors[propertyName];
                else
                    return string.Empty;
            }
        }

        /// <summary>
        /// This method actually does the work of validation.  Must be implemented in each validator class
        /// </summary>
        /// <param name="propertyName">Name of property to validate</param>
        /// <param name="obj">An instance of the object of type T</param>
        public abstract void ValidateProperty(string propertyName, T obj);
    }
}
