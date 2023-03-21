using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public Boolean Onduty { get; set; }
        public int numPassenger { get; set; }

        public void info()
        {
            Console.WriteLine("\n Info Taxi\n");
            Console.WriteLine("Nama Driver : {0}", DriverName);

            if (Onduty == true)
            {
                Console.WriteLine("Narik : iya", Onduty);
            }
            else
            {
                Console.WriteLine("Narik : Tidak", Onduty);
            }

            Console.WriteLine("Nomor pelanggan : {0}", numPassenger);
        }
        public void jemput()
        {
            Console.WriteLine("\n {0} Sedang menjemput penumpang", DriverName);
        }
        public void turun()
        {
            Console.WriteLine("\n {0} Selesai mengantar penumpang", DriverName);

        }
    }
}
