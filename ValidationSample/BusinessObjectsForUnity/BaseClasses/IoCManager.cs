using BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BaseClasses
{
    public class IoCManager
    {
        private static IoCManager _Instance;
        private IoCManager() 
        {
            // change this and you are looking at a diff Ioc
            //  Any is fine as long as it implements IIoc
            _IocContainer = new IoC();
        }
        //  this will hold the default IocContainer
        //  If you switch to a different framework, 
        //  you might use this class
        private IIoc _IocContainer;
        public static IoCManager Current
        {
            get
            {
                if (_Instance == null)
                    _Instance = new IoCManager();

                return _Instance;
            }
        }
        public IIoc DefaultIocContainer
        {
            get
            {
                return _IocContainer;
            }
        }
    }
}
