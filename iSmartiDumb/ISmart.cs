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
            throw new NotImplementedException();
        }
    }
    class GalaxyS2 : ISmart
    {
        string ISmart.getName()
        {
            throw new NotImplementedException();
        }
    }

    class Titan : ISmart
    {
        string ISmart.getName()
        {
            throw new NotImplementedException();
        }
    }
}
