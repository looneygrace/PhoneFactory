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
        public PhoneTypeChecker(Manufacturers m)
        {
            manu = m;


        }
        public void CheckProducts()
        {
            
            if (manu == Manufacturers.NOKIA)
            {
                factory = new NokiaFactory();
                IDumb asha = factory.GetDumb();
                ISmart lumia = factory.GetSmart();
                Console.WriteLine("Smart: " + lumia.getName());
                Console.WriteLine("Dumb: " + asha.getName());
            }
            else if (manu == Manufacturers.HTC)
            {
                factory = new HTCFactory();
                IDumb dumb = factory.GetDumb();
                ISmart smart = factory.GetSmart();
                Console.WriteLine("Smart: " + smart.getName());
                Console.WriteLine("Dumb: " + dumb.getName());
            }
            else if (manu == Manufacturers.SAMSUNG)
            {
                factory = new SamsungFactory();
                IDumb dumb = factory.GetDumb();
                ISmart smart = factory.GetSmart();
                Console.WriteLine("Smart: " + smart.getName());
                Console.WriteLine("Dumb: " + dumb.getName());
            }
        }

    }
    public enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
}
