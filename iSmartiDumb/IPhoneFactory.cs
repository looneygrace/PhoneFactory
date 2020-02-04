using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSmartiDumb
{
    interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();
    }
    class SamsungFactory : IPhoneFactory
    {
        IDumb IPhoneFactory.GetDumb()
        {
            throw new NotImplementedException();
        }

        ISmart IPhoneFactory.GetSmart()
        {
            throw new NotImplementedException();
        }
    }
    class HTCFactory : IPhoneFactory
    {
        IDumb IPhoneFactory.GetDumb()
        {
            throw new NotImplementedException();
        }

        ISmart IPhoneFactory.GetSmart()
        {
            throw new NotImplementedException();
        }
    }
    class NokiaFactory : IPhoneFactory
    {
        IDumb IPhoneFactory.GetDumb()
        {
            throw new NotImplementedException();
        }

        ISmart IPhoneFactory.GetSmart()
        {
            throw new NotImplementedException();
        }
    }
}
