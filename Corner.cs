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
    class Corner : Bet
    {
        public Corner(string selection) : base(selection) { Name = "Corner"; }

        public override bool IsWinner(string winningNumber)
        {
            int number = Int32.Parse(winningNumber);
            string[] corner = Selection.Split('/');
            int[] split = { Int32.Parse(corner[0].ToString()),
                            Int32.Parse(corner[1].ToString()),
                            Int32.Parse(corner[2].ToString()),
                            Int32.Parse(corner[3].ToString()) };

            for (int i = 0; i < 4; i++)
            {
                if (number == split[i])
                {
                    return true;
                }
            }
            return false;
        }
    }


}

