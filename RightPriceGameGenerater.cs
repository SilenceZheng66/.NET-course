using System;
using System.Collections.Generic;
using System.Text;

namespace TheRightPriceGame
{
    public class RightPriceGameGenerator : GameGenerator
    {
        public List<Game> GetGame(int number)
        {
            List<Game> glist = new List<Game>(number);

            for (int i = 0; i < number; i++)
            {
                glist.Add(new Game());
            }

            return glist;
        }
    }
}
