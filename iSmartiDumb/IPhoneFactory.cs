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

            return new Genie();
        }

        ISmart IPhoneFactory.GetSmart()
        {
            return new GalaxyS2();
        }
    }
    class HTCFactory : IPhoneFactory
    {
        IDumb IPhoneFactory.GetDumb()
        {
            return new Primo();
        }

        ISmart IPhoneFactory.GetSmart()
        {
            return new Titan();
        }
    }
    class NokiaFactory : IPhoneFactory
    {
        IDumb IPhoneFactory.GetDumb()
        {
            Asha asha = new Asha();
            return asha;
        }

        ISmart IPhoneFactory.GetSmart()
        {
            Lumia lumia = new Lumia();
            return lumia;
        }
    }
}
