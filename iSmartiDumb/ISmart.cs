using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSmartiDumb
{
    interface ISmart
    {
        string getName();
    }
    class Lumia : ISmart
    {
        string ISmart.getName()
        {
            return "Lumia";
        }
    }
    class GalaxyS2 : ISmart
    {
        string ISmart.getName()
        {
            return "GalaxyS2";
        }
    }

    class Titan : ISmart
    {
        string ISmart.getName()
        {
            return "Titan";
        }
    }
}
