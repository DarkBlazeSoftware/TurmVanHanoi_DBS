using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorenvanHanoi
{
    class Forloop
    {
        public static void Hanoi()
        {







            /*int invoer = Berekenaar.Parsedisks;

            for (int disks = 0; disks <= input; disks++)

            {
                zetten = 0;

                for (uint macht = 0; macht < disks; macht++)
                {
                    zetten = zetten * 2 + 1;

                }

            }*/

            ulong movesholder;

            int input = Calculator.ParseDisks();
            
            for (int disks = 0; disks <= input; disks++)
            {


                movesholder = 0;

                for (uint i = 0; i <= input; i++)
                {
                   ulong moves = movesholder * 2 + 1;
                }

            }




        }
    }
}

