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
    abstract class Bet
    {
        public string Name { get; set; }
        public string Selection { get; }

        public Bet(string selection)
        {
            Selection = selection;
        }
        public abstract bool IsWinner(string winningNumber);


    }


}

