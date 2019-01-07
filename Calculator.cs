using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorenvanHanoi
{
    class Calculator
    {
        public static int ParseDisks()
        {
            // Declaring variables
            string input;
            int disks;

            // User input
            do
            {
                Console.WriteLine("Enter an amount of disks (0-64): ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out disks) || disks < 0 || disks > 64);

            // Calculation
            return disks;
        }





    }
}
