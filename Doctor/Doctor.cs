using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    class Doctor
    {
        string Name;
        int age;
        int exp;
        int phone;

        public string Name1 { get => Name; set => Name = value; }
        public int Age { get => age; set => age = value; }
        public int Exp { get => exp; set => exp = value; }
        public int Phone { get => phone; set => phone = value; }

        public Doctor()
        {
            Console.WriteLine("Object is created");

            Name1 = "Dr. Shyam";
            Age = 24;
            Exp = 1;
            Phone = 987678643;
        }
        ~Doctor()
        {
            Console.WriteLine("GoodBye from {0}", Name1);
            Console.ReadKey();
        }
        public void input()
        {
            Console.WriteLine("User enter the name of the Doctor:");
            Name1= Console.ReadLine();
            Console.WriteLine("User enter the age of the doctor:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User enter the experience of the doctor:");
            Exp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User enter the phone number of the doctor:");
            Phone = Convert.ToInt32(Console.ReadLine());
            
        }
        public void print()
        {
            Console.WriteLine("The details of the doctor are {0}, {1}, {2}, {3}.", Name1, Age, Exp, Phone);
        }
    }
}
