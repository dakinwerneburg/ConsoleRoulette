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
    class SixNumber : Bet
    {
        public SixNumber(string selection) : base(selection) { Name = "SixNumber"; }
        public override bool IsWinner(string bin)
        {

            int number = Int32.Parse(bin);
            string[] doubleRow = Selection.Split(',');

            int[] rows = { Int32.Parse(doubleRow[0].ToString()), Int32.Parse(doubleRow[1].ToString()) };

            int High = rows[1] * 3;
            int Low = High - 5;

            if (number >= Low && number < High)
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

