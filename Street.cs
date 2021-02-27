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
    class Street : Bet
    {
        public Street(string selection) : base(selection) { Name = "Street"; }
        public override bool IsWinner(string bin)
        {
            int row = (int)Math.Ceiling(Double.Parse(bin) / 3);
            if (row == Int32.Parse(Selection))
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

