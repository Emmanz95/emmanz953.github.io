using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesandLaddersUT
{
    public class Snakes_and_Ladders
    {
        string _Game;
        int _token;

        public Snakes_and_Ladders(string Game, int token)
        {
            _Game = Game;
            _token = token;
        }

        public int token { get { return _token; } }

        public void Game(string Game)
        {

        }
    }
}


