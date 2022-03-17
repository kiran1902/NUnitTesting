using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class Sqrt
    {
        public void Root()
        {
            
            Console.WriteLine("Enter the Number : ");
            double C = Convert.ToDouble(Console.ReadLine());
            double L = 0.00001;
            double T = C;
            double sqrt;
            int count = 0;

            while (true)
            {
                count++;
                sqrt = 0.5 * (T + (C / T));

                if (Math.Abs(sqrt - T) < L)
                {
                    break;
                }
                T = sqrt;
            }
            Console.WriteLine("The Square Root is : " +Math.Round(sqrt , 2));


        }
    }
}
