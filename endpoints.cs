using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linecomp
{
    internal class endpoints
    {
        public static void checklength() 
        {
            Console.WriteLine("Enter the first coordinates (x1 & y1): ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first coordinates (x2 & y2): ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());

            double temp1 = Math.Pow((x2 - x2), 2);
            double temp2 = Math.Pow((x2 - x2), 2);
            double result = Math.Sqrt(temp1 + temp2);

            Console.WriteLine(result);

        }


    }
}

