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

namespace ccsbs_ex07_werneburg
{
    class Program
    {
        static void Main()
        {
            Console.WindowHeight = Console.WindowHeight +10;
            Console.WindowWidth = Console.WindowWidth -50;
            RouletteTable rouletteTable = new RouletteTable();
           

            //Presents Information Related to the game
            rouletteTable.DrawGameIntroduction();
            rouletteTable.ShowBetInformation();
            Console.ResetColor();


            //Spins the Roulette Wheel and will simulate the ball and bin
            string BinSlot = rouletteTable.RouletteWheel.SpinWheel();

            Console.Clear();
            rouletteTable.DrawRouletteTable();
            rouletteTable.RouletteWheel.DrawWheel();
            Console.ResetColor();

            //Iterates through all the bets placed and prints results to console.
            foreach (Bet bet in rouletteTable.Bets)
            {
                if (bet.IsWinner(BinSlot))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"The bet was called: {bet.Name,-10}  You selected: {bet.Selection,-15} and the bin landed on: {BinSlot}");
                    Console.WriteLine($"   -  WINNER!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"The bet was called: {bet.Name,-10}  You selected: {bet.Selection,-15} and the bin landed on: {BinSlot}");
                }
            }
            Console.SetCursorPosition(0, 0);



            Console.ReadKey();


        }

       



    }


}

