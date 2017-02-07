using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_C
{
    class C2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Gender M or F : ");
            string gender = Console.ReadLine();
            Console.Write("Enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (gender == "M")
            {
                if(age>=45)
                {
                    Console.WriteLine("Good Morning Uncle" + name);
                }
                else
                {
                    Console.WriteLine("Good Morning Mr." + name);
                }
            }               
            else if (gender == "F")
            {
                if (age >= 45)
                {
                    Console.WriteLine("Good Morning Lady " + name);
                }
                else
                {
                    Console.WriteLine("Good Morning Ms." + name);
                }
            }
            else
            {
                Console.WriteLine("Please enter M or F for Gender!");
            }
        }
    }
}
