using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class Prog
    {
        //user input
        public void Calendar()
        {
            Console.WriteLine("Enter the Month : ");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Date : ");
            int D = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Year : ");
            int Y = int.Parse(Console.ReadLine());

            //formulas of Gregorian calendar
            int y0 = Y - (14 - M) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = M + 12 * ((14 - M) / 12);
            int d0 = (D * x + 31 * m0 / 12) % 7;

            //switch condition
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;

                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
