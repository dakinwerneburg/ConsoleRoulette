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
    class EvenOdd : Bet
    {
        public EvenOdd(string selection) : base(selection) { Name = "EvenOdd"; }
        public override bool IsWinner(string winningNumber)
        {

            int number = Int32.Parse(winningNumber);

            if (number % 2 == 0 && Selection == "Even")
            {
                return true;
            }
            else if (number % 2 != 0 && Selection == "Odd")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}

