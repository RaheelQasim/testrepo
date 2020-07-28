using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinic clin = new Clinic();
            clin.input();
            clin.printdetails();
            GC.Collect();
            //Console.ReadKey();

        }
    }
}
