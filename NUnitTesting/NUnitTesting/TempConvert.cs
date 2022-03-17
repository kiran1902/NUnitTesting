using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class TempConvert
    {
        //class for converting temperature from celsius to farhenheit
        public void CelsiusToFahrenheit()
        {
            double celsius,fahrenheit ;
            Console.WriteLine("Enter the Temperature in Celsius (°C) : ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is (°F) : " + fahrenheit);
        }

        //class for converting temperature from farhenheit to celsius
        public void FahrenheitToCelsius()
        {
            double fahrenheit, celsius;
            Console.WriteLine("Enter the Temperature in Farhenheit(°F) : ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius is (°C) : " + celsius);
        }
    }
}
