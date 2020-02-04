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
            return "Asha";
        }
    }
    class Genie : IDumb
    {
        string IDumb.getName()
        {
            return "Genie";
        }
    }
    class Primo : IDumb
    {
        string IDumb.getName()
        {
            return "Primo";
        }
    }
}
