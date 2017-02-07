using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_C
{
    class C3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Marks : ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if(mark>=80 && mark<=100)
            {
                    Console.WriteLine("You scored "+mark+" marks wich is A grade");
            }
            else if(mark >= 60 && mark <= 79)
            {
                Console.WriteLine("You scored " + mark + " marks wich is B grade");
            }
            else if(mark >= 40 && mark <= 59)
            {
                Console.WriteLine("You scored " + mark + " marks wich is C grade");
            }
            else if(mark >= 0 && mark <= 40)
            {
                Console.WriteLine("You scored " + mark + " marks wich is F grade");
            }
            else
            {
                Console.WriteLine("**Error**");
            }
        }
    }
}
