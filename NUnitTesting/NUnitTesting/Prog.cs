using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class Prog
    {
        public void machine()
        {
            int[] arrNotes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine("Enter the ammount to change /n {2000, 500, 200, 100, 50, 20, 10, 5, 2, 1}");
            int amount = int.Parse(Console.ReadLine());

            //Looping to count notes
            for (int i = 0; i < arrNotes.Length; i++)
            {
                int noOfNotes = 0;
                if (amount >= arrNotes[i])
                {
                    noOfNotes =  amount / arrNotes[i];
                    //using mod(%) to find change
                    amount = amount % arrNotes[i];

                    Console.WriteLine(+arrNotes[i]+ "Number of notes : " +noOfNotes);
                }
                Console.ReadLine();
            }
        }
    }
}
