using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Interfaces
{
    public interface IIoc
    {
        //  Generic method  Returns an instance of 
        //  whatever you provide for T
        //  Factory only gives out Employee Validators and is
        //  somewhat limited.  Unity can give out validators for
        //  ANY object...so if you add a product and a validator
        //  Just add the mapping in the app.config and it will 
        //  connect the two together
        T FetchDependancy<T>();
    }
}
