using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _26June20
{
    class Program
    {
        void add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("The sum is {0}",+sum);
            
        }

        void multiply(int a, int b, int c)
        {
            int prod = a * b * c;
            Console.WriteLine("The product is {0}",+prod);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //int a, b, c;
            //Console.WriteLine("User enter the first number:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("User enter the second number:");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("User enter the third number:");
            //c = Convert.ToInt32(Console.ReadLine());
            //if (a>b)
            //{
            //    if (a>c)
            //    {
            //        Console.WriteLine("{0} is the largest number",+a);
            //        Console.ReadKey();
            //    }
            //    else if (b>c)
            //    {
            //        Console.WriteLine("{0} is the largest number",+b);
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} is the largest number",+c);
            //        Console.ReadKey();
            //    }

            //}
            //else if (b > c)
            //{
            //    Console.WriteLine("{0} is the largest number", +b);
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("{0} is the largest number", +c);
            //    Console.ReadKey();
            //}
            //string w,u,l;
            //Console.WriteLine("User enter a string:");
            //w = Console.ReadLine();
            //Console.WriteLine("The entered string is {0}",w);
            //l=w.ToLower();
            //Console.WriteLine("The entered string in lower case is {0}", l);
            //u=w.ToUpper();
            //Console.WriteLine("The entered string in upper case is {0}", u);
            //Console.ReadKey();
            //string w;

            //Console.WriteLine("User enter a string:");
            //w = Console.ReadLine();
            //int length = w.Length;

            //Console.WriteLine("The length of the string is {0}", length);
            //Console.ReadKey();

            Program prg = new Program();
            int a, b, c;
            Console.WriteLine("User enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User enter the third number:");
            c = Convert.ToInt32(Console.ReadLine());
            prg.add(a,b,c);
            prg.multiply(a, b, c);
        }
    }
}
