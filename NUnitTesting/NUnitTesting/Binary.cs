using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class Binary
    {
         public void Test()
        {
            int n, i; //local variables

            int[] arr = new int[10];// calling an array
           
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
           //looping
            for (i = 0; n > 0; i++)
            {
                arr[i] = n % 2;
                n = n / 2;
            }
            
            Console.Write("Binary of the given number : ");
           // Binary Looping
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
    }


}
