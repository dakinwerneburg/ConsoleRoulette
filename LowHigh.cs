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
    class LowHigh : Bet
    {
        public LowHigh(string selection) : base(selection) { Name = "LowHigh"; }
        public override bool IsWinner(string bin)
        {
            int number = Int32.Parse(bin);
            if (number > 0 && number < 19 && Selection == "Low")
            {
                return true;
            }
            else if (number > 18 && number < 36 && Selection == "High")
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

