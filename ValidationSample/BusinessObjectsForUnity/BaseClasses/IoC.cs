using BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;



namespace BusinessObjects.BaseClasses
{
    public class IoC : IIoc
    {
        private IUnityContainer _Ioc;

        public IoC()
        {
            try
            {
                //  This creates a new unitycontainer object 
                //  It does all the injection work for us
                _Ioc = new UnityContainer();

                //  Load the app.config section titled "unity"
                UnityConfigurationSection section =
                    (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
                
                //  Point that section to the new container and 
                //  Tell it to add all dependancies found in the config
                //  INto the UnityContainer
                section.Configure(_Ioc);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T FetchDependancy<T>()
        {
            //  Calls on Unity to find the right class based on config
            return _Ioc.Resolve<T>();
        }
    }
}
