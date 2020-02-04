using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSmartiDumb
{
    class PhoneTypeChecker
    {
        IPhoneFactory factory;
        Manufacturers manu;
        PhoneTypeChecker(Manufacturers m)
        {
            if(m == Manufacturers.NOKIA)
            {
                IPhoneFactory f = new NokiaFactory();
                IDumb asha = f.GetDumb();
                ISmart lumia = f.GetSmart();
                Console.WriteLine("Smart: " + lumia.getName());
                Console.WriteLine("Dumb: " + asha.getName());
            }
            else if (m == Manufacturers.HTC)
            {
                IPhoneFactory f = new HTCFactory();
                IDumb dumb = f.GetDumb();
                ISmart smart = f.GetSmart();
                Console.WriteLine("Smart: " + smart.getName());
                Console.WriteLine("Dumb: " + dumb.getName());
            }
            else if (m == Manufacturers.SAMSUNG)
            {
                IPhoneFactory f = new SamsungFactory();
                IDumb dumb = f.GetDumb();
                ISmart smart = f.GetSmart();
                Console.WriteLine("Smart: " + smart.getName());
                Console.WriteLine("Dumb: " + dumb.getName());
            }



        }
        void CheckProducts()
        {

        }

    }
    public enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
}
