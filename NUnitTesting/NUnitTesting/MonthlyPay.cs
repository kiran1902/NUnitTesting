using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class MonthlyPay
    {
        public void Loan()
        {
            //input principal from user
            Console.WriteLine("Enter the Principal Amount : ");
            double Principal = Convert.ToDouble(Console.ReadLine());

            //input rate from user
            Console.WriteLine("Enter Rate Of Interest : ");
            double Rate = Convert.ToDouble(Console.ReadLine());
            Rate = Rate / (12 * 100); //rate formula

            //input year from the user
            Console.WriteLine("Enter Number of Years : ");
            double Year = Convert.ToDouble(Console.ReadLine());
            Year = 12 * Year; //year formula

            double pay = (Principal * Rate) / 1 - (1 - Rate)Math.Pow(-Year);
            Console.WriteLine("The Payment Amount", + pay);

        }
    }
}
