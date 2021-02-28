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
using System.Collections.Generic;

namespace ccsbs_ex07_werneburg
{
    class RouletteTable
    {
        public List<Bet> Bets { get; }

        public RouletteWheel RouletteWheel { get; }
        public RouletteTable()
        {
            RouletteWheel = new RouletteWheel();
            Bets = new List<Bet>();
        }

        public void ShowBetInformation()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("**************************************************************************\n" +
                              "*                     Bets                                               *\n" +
                              "*                                                                        *\n" +
                              "*  1. Numbers:  Pick a Number 0-36                                       *\n" +
                              "*  2. Evens / Odds: even or odd numbers                                  *\n" +
                              "*  3. Reds / Blacks: red or black colored numbers                        *\n" +
                              "*  4. Lows / Highs: low(1 – 18) or high(19 – 38) numbers.                *\n" +
                              "*  5. Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36                       *\n" +
                              "*  6. Columns: first, second, or third columns                           *\n" +
                              "*  7. Street: rows, e.g., 1 / 2 / 3 or 22 / 23 / 24                      *\n" +
                              "*  8. 6 Numbers: double rows, e.g., 1 / 2 / 3 / 4 / 5 / 6                *\n" +
                              "*  9. Split: at the edge of any two contiguous numbers,                  *\n" +
                              "*             e.g., 1 / 2,    11 / 14,   and 35 / 36                     *\n" +
                              "*  10.Corner: at the intersection of any four contiguous numbers,        *\n" +
                              "*             e.g., 1 / 2 / 4 / 5, or 23 / 24 / 26 / 27                  *\n" +
                              "*                                                                        *\n" +
                              "*                    Press Any Key To Continue                           *\n" +
                              "**************************************************************************\n");
            Console.ResetColor();
            Console.ReadKey();
            Console.Write("Would you like Place Random Bets Automatically? (Y or N):  ");
            string auto = Console.ReadLine();
            if (auto == "Y" || auto == "y")
            {
                MakeAutoBets();
            }
            else if (auto == "N" || auto == "n")
            {
                MakeManualBets();
            }
            Console.Clear();
        }
        public void GetOdds()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*****************************************************************\n" +
                          "*                        Odds                                   *\n" +
                          "*                                                               *\n" +
                          "*       Numbers   - 35:1              Probility - 2.6%          *\n" +
                          "*       Even/Odds -  1:1              Probility - 47.3%         *\n" +
                          "*       Red/Black -  1:1              Probility - 47.3%         *\n" +
                          "*       Low/High  -  1:1              Probility - 47.3%         *\n" +
                          "*       Dozens    -  2:1              Probility - 31.6%         *\n" +
                          "*       Columns   -  2:1              Probility - 31.6%         *\n" +
                          "*       Street    - 11:1              Probility -  7.9%         *\n" +
                          "*       6 Number  -  5:1              Probility - 15.8%         *\n" +
                          "*       Split     - 17:1              Probility -  5.3%         *\n" +
                          "*       Corner    -  8:1              Probility - 10.5%         *\n" +
                          "*                                                               *\n" +
                          "*                Press Any Key To Continue                      *\n" +
                          "*****************************************************************");
            Console.ResetColor();
        }

        public void DrawGameIntroduction()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*****************************************************************\n" +
                              "*                  Welcome To Microsoft                         *\n" +
                              "*                Software & Systems Academy                     *\n" +
                              "*                       Roulette                                *\n" +
                              "*                                                               *\n" +
                              "*      Simulates Roulette.  Player can enter each selection     *\n" +
                              "*      for each of the required bets, or can just spin with     *\n" +
                              "*      random picks.  Good Luck.                                *\n" +
                              "*                  Press Any key to Continue                    *\n" +
                              "*                                                               *\n" +
                              "*****************************************************************");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Uses the Random class to get random integers and simulate Bets
        /// </summary>
        public void MakeAutoBets()
        {
            Bin bin = new Bin();

            Random rand = new Random();

            //NUMBER AUTO
            int selection = rand.Next(0, 38);
            Bets.Add(new Number(bin.Numbers[selection]));

            //EVEN ODD AUTO
            selection = rand.Next(0, 38);
            if (selection % 2 == 0)
            {
                Bets.Add(new EvenOdd("Even"));
            }
            else
            {
                Bets.Add(new EvenOdd("Odd"));
            }


            //RED BLACK AUTO
            selection = rand.Next(0, 37);
            if (ConsoleColor.Red == bin.NumberColor[selection.ToString()])
            {
                Bets.Add(new RedBlack("Red"));
            }
            else if (ConsoleColor.Black == bin.NumberColor[selection.ToString()])
            {
                Bets.Add(new RedBlack("Black"));
            }
            else
            {
                Bets.Add(new RedBlack("Green"));
            }

            //LOW HIGH AUTO
            selection = rand.Next(0, 36);
            if (selection > 18)
            {
                Bets.Add(new LowHigh("High"));
            }
            else
            {
                Bets.Add(new LowHigh("Low"));
            }

            //DOZEN AUTO
            selection = rand.Next(1, 3);
            Bets.Add(new Dozen(selection.ToString()));

            //COLUMN AUTO
            selection = rand.Next(1, 3);
            Bets.Add(new Column(selection.ToString()));

            //STREET AUTO
            selection = rand.Next(1, 12);
            Bets.Add(new Street(selection.ToString()));

            //SIX NUMBER AUTO
            selection = rand.Next(1, 11);
            Bets.Add(new SixNumber(selection.ToString() + "," + (selection + 1).ToString()));



            //SPLIT AUTO
            while (true)
            {
                selection = rand.Next(1, 36);
                if (selection % 3 != 0)
                {
                    Bets.Add(new Split(selection.ToString() + "," + (selection + 1).ToString()));
                    break;
                }
            }

            //CORNER
            selection = rand.Next(0, 21);
            Bets.Add(new Corner(bin.Corner[selection]));
        }

        /// <summary>
        /// Prompts user for input and Adds to the list of Bets
        /// </summary>
        public void MakeManualBets()
        {
            //TODO: Need Validation of Input implemented

            Console.Write("Please pick a number 1-36, 0 or 00:    ");
            Bets.Add(new Number(Console.ReadLine()));

            Console.Write("Please Enter \"Even\" or \"Odd\":   ");
            Bets.Add(new EvenOdd(Console.ReadLine()));

            Console.Write("Please Enter \"Red\" or \"Black\":   ");
            Bets.Add(new RedBlack(Console.ReadLine()));

            Console.Write("Please Enter \"Low\" or \"High\":   ");
            Bets.Add(new LowHigh(Console.ReadLine()));

            Console.Write("Please Enter Dozen Number  1, 2, or 3:   ");
            Bets.Add(new Dozen(Console.ReadLine()));

            Console.Write("Please Enter Column Number  1, 2, or 3:   ");
            Bets.Add(new Column(Console.ReadLine()));

            Console.Write("Please Enter Row Number  1-12:   ");
            Bets.Add(new Street(Console.ReadLine()));

            Console.Write("Please Enter two consecutive rows i.e  1,2:   ");
            Bets.Add(new SixNumber(Console.ReadLine()));

            Console.Write("Please Enter two consecutive number i.e  11,14:   ");
            Bets.Add(new Split(Console.ReadLine()));

            Console.Write("Please Enter four numbers for a corner i.e  1,2,3,4:   ");
            Bets.Add(new Number(Console.ReadLine()));
        }

        /// <summary>
        /// This was an inpsiration I found online  Wish I had time to implement
        /// this with better colors and the original artist intended
        /// 
        /// https://github.com/Oneiros90/Roulette
        /// </summary>
        public void DrawRouletteTable()
        {

            Console.WriteLine("Street:    1      2      3      4      5      6     7       8      9     10     11     12               ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("    ____________________________________________________________________________________________________");
            Console.WriteLine("   /   |      |      |      |      |      |      |      |      |      |      |      |      |           |");
            Console.WriteLine("  /  0 |   3  |   6  |   9  |  12  |  15  |  18  |  21  |  24  |  27  |  30  |  33  |  36  |  2 to 1   |");
            Console.WriteLine(" /_____|______|______|______|______|______|______|______|______|______|______|______|______|___________|");
            Console.WriteLine(" |     |      |      |      |      |      |      |      |      |      |      |      |      |           |");
            Console.WriteLine(" |  0  |   2  |   5  |   8  |  11  |  14  |  17  |  20  |  23  |  26  |  29  |  32  |  35  |  2 to 1   |");
            Console.WriteLine(" |  0  |______|______|______|______|______|______|______|______|______|______|______|______|___________|");
            Console.WriteLine(" |     |      |      |      |      |      |      |      |      |      |      |      |      |           |");
            Console.WriteLine("  \\    |   1  |   4  |   7  |  10  |  13  |  16  |  19  |  22  |  25  |  28  |  31  |  34  |  2 to 1   |");
            Console.WriteLine("   \\___|______|______|______|______|______|______|______|______|______|______|______|______|___________|");
            Console.WriteLine("       |                           |                           |                           |            ");
            Console.WriteLine("       |          1st 12           |          2nd 12           |           3rd 12          |            ");
            Console.WriteLine("       |___________________________|___________________________|___________________________|            ");
            Console.WriteLine("       |            |              |             |             |            |              |            ");
            Console.WriteLine("       |  1 to 18   |  EVEN        |      RED    |    BLACK    |     ODD    |  19 to 36    |            ");
            Console.WriteLine("       |____________|______________|_____________|_____________|____________|______________|            ");

        }


    }


}

