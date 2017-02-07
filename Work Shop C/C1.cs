using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_C
{
    class C1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : " );
            string name = Console.ReadLine();
            Console.Write("Enter your Gender M or F : ");
            string gender = Console.ReadLine();
            if(gender=="M")
            {
                Console.WriteLine("Good Morning Mr." + name);
            }
            else if(gender=="F")
            {
                Console.WriteLine("Good Morning Ms." + name);
            }
            else
            {
                Console.WriteLine("Please enter M or F for Gender!" );
            }
        }
    }
}
