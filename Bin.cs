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
using System.Collections.Generic;

namespace ccsbs_ex07_werneburg
{
    /// <summary>
    /// Defines the various number and bet cobminations that are available on 
    /// a table
    /// </summary>
    class Bin
    {
        public Dictionary<string, ConsoleColor> NumberColor { get; }
        public Dictionary<int, string> Corner { get; }
        public string[] Numbers { get; }

        public Bin()
        {
            //Defins What Numbers and the order they are in the bin
            Numbers = new string[] {"0 ", "28", "9 ", "26", "30", "11", "7 ", "20",
                                     "32", "17", "5 ", "22", "34", "15", "3 ", "24",
                                     "36", "31", "1 ", "00", "27", "10", "25", "29",
                                     "12", "8 ", "19", "31", "18", "6 ", "21", "33",
                                     "16", "4 ", "23", "35", "14", "2 " };

            
            //Defines the color associated with a number
            NumberColor = new Dictionary<string, ConsoleColor>();
            NumberColor.Add("0", ConsoleColor.Green);
            NumberColor.Add("00", ConsoleColor.Green);
            for (int i = 1; i <= 36; i++)
            {
                if (i > 0 && i < 11 || i > 18 && i < 29)
                {
                    if (i % 2 == 0)
                    {
                        NumberColor.Add(i.ToString(), ConsoleColor.Black);
                    }
                    else
                    {
                        NumberColor.Add(i.ToString(), ConsoleColor.Red);
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        NumberColor.Add(i.ToString(), ConsoleColor.Red);
                    }
                    else
                    {
                        NumberColor.Add(i.ToString(), ConsoleColor.Black);
                    }
                }
            }

            //Defines what numbers are associated with a corner
            Corner = new Dictionary<int, string>();
            Corner.Add(0, "1/2/4/5");
            Corner.Add(1, "2/3/5/6");
            Corner.Add(2, "4/5/7/8");
            Corner.Add(3, "5/6/8/9");
            Corner.Add(4, "7/8/10/11");
            Corner.Add(5, "8/9/11/12");
            Corner.Add(6, "10/11/13/14");
            Corner.Add(7, "11/12/14/15");
            Corner.Add(8, "13/14/16/17");
            Corner.Add(9, "14/15/17/18");
            Corner.Add(10, "16/17/19/20");
            Corner.Add(11, "17/18/20/21");
            Corner.Add(12, "19/20/22/23");
            Corner.Add(13, "20/21/23/24");
            Corner.Add(14, "22/23/25/26");
            Corner.Add(15, "23/24/25/27");
            Corner.Add(16, "25/26/28/29");
            Corner.Add(17, "26/27/29/30");
            Corner.Add(18, "28/29/31/32");
            Corner.Add(19, "29/30/32/33");
            Corner.Add(20, "31/32/34/35");
            Corner.Add(21, "32/33/35/36");
        }
    }


}

