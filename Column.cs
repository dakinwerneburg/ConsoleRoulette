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
    class Column : Bet
    {
        public Column(string selection) : base(selection) { Name = "Column"; }
        public override bool IsWinner(string bin)
        {
            int number = Int32.Parse(bin);

            if (number % 3 == Int32.Parse(Selection))
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

