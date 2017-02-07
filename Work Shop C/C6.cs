using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_C
{
    class C6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the quantity for TV : ");
            int Tv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the quantity for Dvd : ");
            int Dvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the quantity for Mp3 : ");
            int Mp3 = Convert.ToInt32(Console.ReadLine());
            double amtmp3=0.0, amtTv=0.0, amtdvd=0.0;
            if (Tv > 0)
            {
                 amtTv = Tv * 900;
                if (amtTv > 5000)
                {
                    amtTv = amtTv - (amtTv * 0.1);
                }
                if (amtTv > 10000)
                {
                    amtTv = amtTv - (amtTv * 0.15);
                }
            }
            if (Dvd > 0)
            {
                amtdvd = Dvd * 500;
                if (amtdvd > 5000)
                {
                    amtdvd = amtdvd - (amtdvd * 0.1);
                }
                if (amtdvd > 10000)
                {
                    amtdvd = amtdvd - (amtdvd * 0.15);
                }
            }
            if (Mp3>0)
            {
                 amtmp3 = Mp3 * 700;
            }
            double discountamt = amtTv + amtdvd + amtmp3;
            Console.WriteLine("Discounted Price : " +discountamt);
        }
    }
}
