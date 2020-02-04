using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSmartiDumb
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker nPhone = new PhoneTypeChecker(Manufacturers.NOKIA);
            PhoneTypeChecker hPhone = new PhoneTypeChecker(Manufacturers.HTC);
            PhoneTypeChecker sPhone = new PhoneTypeChecker(Manufacturers.SAMSUNG);

            Console.WriteLine("Nokia: ");
            nPhone.CheckProducts();
            Console.WriteLine("HTC: ");
            hPhone.CheckProducts();
            Console.WriteLine("Samsung: ");
            sPhone.CheckProducts();
            Console.ReadKey();
        }
    }
}
