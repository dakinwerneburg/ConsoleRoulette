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
    class Dozen : Bet
    {
        public Dozen(string selection) : base(selection) { Name = "Dozen"; }
        public override bool IsWinner(string bin)
        {
            int number = Int32.Parse(bin);
            if (number > 0 && number < 13 && Selection == "1")
            {
                return true;
            }
            else if (number > 12 && number < 25 && Selection == "2")
            {
                return true;
            }
            else if (number > 24 && number < 37 && Selection == "3")
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

