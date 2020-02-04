using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSmartiDumb
{
    interface IDumb
    {
        string getName();
    }
    class Asha : IDumb
    {
        string IDumb.getName()
        {
            throw new NotImplementedException();
        }
    }
    class Genie : IDumb
    {
        string IDumb.getName()
        {
            throw new NotImplementedException();
        }
    }
    class Primo : IDumb
    {
        string IDumb.getName()
        {
            throw new NotImplementedException();
        }
    }
}
