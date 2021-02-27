/**
 *  Microsoft Software and Systems Academy 
 *  Cloud Applications Certification
 *  Embry Riddle
 *  
 *  Excercise 7 
 *  Author: Dakin T. Werneburg
 *  Date: 2/27/2021
 * 
 */


using System;
using System.Threading;

namespace ccsbs_ex07_werneburg
{
    /// <summary>
    /// Roulette Wheel is composed of three bins.  It will 
    /// then rotate the wheel from right to left only showing 
    /// the previous, current, and next number.  Simple animation
    /// is created using the Console and Thread classes.
    /// </summary>
    class RouletteWheel
    {
        public Bin Bin { get; }
        public string PreviousNumber { get; set; }
        public string CurrentNumber { get; set; }
        public string NextNumber { get; set; }

        public RouletteWheel()
        {
            Bin = new Bin();
        }

        public void DrawWheel()
        {
            //Draws Two Rows of Current Color for each bin for room above number
            for (int k = 0; k < 2; k++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("               ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.BackgroundColor = Bin.NumberColor[PreviousNumber.Trim()];
                Console.Write("     ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.BackgroundColor = Bin.NumberColor[CurrentNumber.Trim()];
                Console.Write("     ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.BackgroundColor = Bin.NumberColor[NextNumber.Trim()];
                Console.Write("     ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" \n");
            }

            //Draws a border and the ball in the bin
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("               ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("|     |  @  |     |\n");
            Console.ForegroundColor = ConsoleColor.White;

            //Displays a row of the associated color bin to give space above number
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("               ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = Bin.NumberColor[PreviousNumber.Trim()];
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = Bin.NumberColor[CurrentNumber.Trim()];
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = Bin.NumberColor[NextNumber.Trim()];
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" \n");

            //Draws number and color of bin
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("               ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = Bin.NumberColor[PreviousNumber.Trim()];
            Console.Write($" {PreviousNumber}  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = Bin.NumberColor[CurrentNumber.Trim()];
            Console.Write($" {CurrentNumber}  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = Bin.NumberColor[NextNumber.Trim()];
            Console.Write($" {NextNumber}  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" \n");

            //Provides some space below the number
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("               ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = Bin.NumberColor[PreviousNumber.Trim()];
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = Bin.NumberColor[CurrentNumber.Trim()];
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = Bin.NumberColor[NextNumber.Trim()];
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" \n");
        }

        public string SpinWheel()
        {


            Console.ForegroundColor = ConsoleColor.White;
            int timer = 1;
            Random rand = new Random();
            int winningNumber = rand.Next(0, 37);

            /*
             * Will run go around all numbers at least 3 times 
             * and on the last iteration will stop at the 
             * winning ball.
             */
            for (int i = 0; i < 1; i++)
            {
                for (int j = 1; j < Bin.Numbers.Length - 1; j++)
                {
                    PreviousNumber = Bin.Numbers[j - 1];
                    CurrentNumber = Bin.Numbers[j];
                    NextNumber = Bin.Numbers[j + 1];

                    int binNumber = Int32.Parse(CurrentNumber);

                    DrawWheel();

                    if (binNumber == winningNumber && i == 0)
                    {
                        Console.ResetColor();
                        break;
                    }
                    //provides for the animation by refreshing every 30 miliseconds
                    Thread.Sleep(timer++);
                    Console.ResetColor();
                    Console.Clear();
                }
            }
            return CurrentNumber;
        }
    }


}

