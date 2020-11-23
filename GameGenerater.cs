using System;
using System.Collections.Generic;
using System.Text;

namespace TheRightPriceGame
{
    public interface GameGenerator
    {
        public List<Game> GetGame(int number);
    }
}
