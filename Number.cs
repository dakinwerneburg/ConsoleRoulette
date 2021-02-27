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

namespace ccsbs_ex07_werneburg
{
    class Number : Bet
    {
        public Number(string selection) : base(selection) { Name = "Number"; }
        public override bool IsWinner(string winningNumber)
        {
            if (winningNumber == Selection)
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

