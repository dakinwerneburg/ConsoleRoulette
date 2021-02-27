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
    class Split : Bet
    {
        public Split(string selection) : base(selection) { Name = "Split"; }
        public override bool IsWinner(string bin)
        {

            int number = Int32.Parse(bin);
            string[] split = Selection.Split(',');
            int first = Int32.Parse(split[0]);
            int second = Int32.Parse(split[1]);

            if (number == first && number == second)
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

