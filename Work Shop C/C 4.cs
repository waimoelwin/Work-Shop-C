using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_C
{
    class C_4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distane : ");
            double distance = Convert.ToDouble(Console.ReadLine());
            if(distance<=.5)
            {
                Console.WriteLine("The cost : $ 2.4");
            }
            else
            {
                double a = Math.Ceiling(distance * 10);
                double ans = Math.Round(a / 10, 1);
                double output = 2.4 + (85 * 0.04) + ((a - 90) * 0.05);
                Console.WriteLine("The cost : $ " + output);
            }
            
        }
    }
}
