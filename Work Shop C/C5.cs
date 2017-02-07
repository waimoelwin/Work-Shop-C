using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_C
{
    class C5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the three-digit number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            double first = number / 100;
            double second = (number % 100) / 10;
            double third = number % 10;
            double value = Math.Pow(first, 3.0) + Math.Pow(second, 3.0) + Math.Pow(third, 3.0);
            if(value==number)
            {
                Console.WriteLine("Ture " );
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
