using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorial_Programs
{
    class Tester
    {
        static void Main(string[] args)
        {
            CodingBatWarmup1 warmup = new CodingBatWarmup1();

            //Test of SleepIn
            Console.WriteLine(warmup.SleepIn(true, true).ToString());  // Should evaluate True
            Console.WriteLine(warmup.SleepIn(true, false).ToString()); // Should evaluate False
            Console.WriteLine(warmup.SleepIn(false, true).ToString()); // Should evaluate True
            Console.WriteLine(warmup.SleepIn(false, false).ToString());// Should evaluate True

            Console.ReadLine();
        }
    }

    class CodingBatWarmup1
    {
        /**
         * Constructor for instances of CodingBatWarmup1
         */
        public CodingBatWarmup1()
        {

        }

        /**
         * Determines whether or not the user can sleep in
         * @param weekday Boolean indicator of whether or not it is a weekday
         * @param vacation Boolean indicator of whether or not the user is on vacation
         * @return A boolean value indicating whether or not the user can sleep in
         */
        public Boolean SleepIn(Boolean weekday, Boolean vacation)
        {
            //Should evaluate true if it is not a weekday or if user is on a vacation
            return (!weekday||vacation);
        }
    }
}
