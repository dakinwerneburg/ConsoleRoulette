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
    class RedBlack : Bet
    {
        private readonly Bin _Bin;
        public RedBlack(string selection) : base(selection)
        {
            _Bin = new Bin();
            Name = "RedBlack";
        }
        public override bool IsWinner(string winningNumber)
        {
            if (_Bin.NumberColor[winningNumber.Trim()] == ConsoleColor.Red && Selection == "Red")
            {
                return true;
            }
            else if (_Bin.NumberColor[winningNumber.Trim()] == ConsoleColor.Black && Selection == "Black")
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

