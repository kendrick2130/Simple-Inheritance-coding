using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a basic phone");
            CellularPhone cp = new CellularPhone();
            cp.TextMessaging();

            Console.WriteLine("This is a smartphone");
            SmartPhone sp = new SmartPhone();
            sp.TextMessaging();

            Console.WriteLine("This is a flip phone");
            FlipPhone fp = new FlipPhone();
            fp.TextMessaging();
            Console.ReadLine();

        }
       
    }
}
