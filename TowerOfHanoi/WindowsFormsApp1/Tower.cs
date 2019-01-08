using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{



    public partial class Tower : Form
    {
        //Global Variables
        ulong minMoves;
        int disks;
        int moves;
        
        public Tower()
        {
            InitializeComponent();
        }


        public int ParseDisks(string diskInput)
        {
            // Declaring variables
            string input;
 

            // User input
            do
            {

                input = diskInput;

            } while (!int.TryParse(input, out disks) || disks < 0 || disks > 64);

            // Calculation
            return disks;
        }
        //Bas
        public void loopFor()
        {
            
            ulong moves;
            
            int input = ParseDisks(disksTextBox.Text);
            
            for (int disks = 0; disks < input; disks++)
            {
                moves = 0;
                
                for (uint energy = 0; energy < input; energy++)
                {
                   
                    moves = moves * 2 + 1;

                    minMoves = moves;
                }
                
            }
            
        }

        public void recursionLoop()
        {
            minMoves = calculate(disks, 0, 0);
            ulong calculate(int disks, int counter, ulong steps)
            {
                if (counter >= disks)
                {
                    return steps;
                }

                steps = steps * 2 + 1;
                counter++;
                return calculate(disks, counter, steps);


            }
        }
        //AJ
        public void powerOfLoop()
        {
            disks = ParseDisks(disksTextBox.Text);
            ulong powerMoves;
            powerMoves =(ulong) Math.Pow(2, disks) - 1;
            minMoves = powerMoves;
        }
        public void timeCheck(ulong tMoves, ulong speed)
        {
            decimal seconds;
            decimal minutes;
            decimal hours;
            decimal days;
            decimal months;
            decimal years;

            seconds = tMoves* speed;

            years = seconds / 31536000;
            months = (seconds % 31536000) / 2592000;
            days = (seconds % 2592000) / 86400;
            hours = (seconds % 86400) / 3600;
            minutes = (seconds % 3600) / 60;
            seconds = seconds % 60;
            years = (ulong)years;
            months = (ulong)months;
            days = (ulong)days;
            hours = (ulong)hours;
            minutes = (ulong)minutes;
            seconds = (ulong)seconds;

            string timeCompletion =  years.ToString()+ " Years " + " : " + months.ToString() +" Months "+ " : " + days.ToString() + " Days " +" : " +hours.ToString() + " Hours " +" : " +minutes.ToString() +" Minutes " + " : " +seconds.ToString() + " Seconds ";
            totalTimeCounter.Text = timeCompletion;
        }






        private void startButton_Click(object sender, EventArgs e)
        {
            int.TryParse(disksTextBox.Text, out disks);
            
            if (disks > 64 || disks< 1)
            {
                MessageBox.Show("Error : Niet meer dan 64 en niet lager dan 1, alstublieft");
            }
            else
            {
                if (loopSelector.Text == "For Loop")
                {
                    loopFor();

                }
                if (loopSelector.Text == "Maxverheffen")
                {
                    powerOfLoop();
                }
                if (loopSelector.Text == "Recursie")
                {
                    recursionLoop();
                }
            }
            timeCheck(minMoves, 1);
           
            totalTurnCounter.Text = minMoves.ToString();
        }

      
    }
}
