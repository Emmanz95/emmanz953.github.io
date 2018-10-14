using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesandLadders
{
    public class SnakesandLadders
    {
        string _Game;
        int _token;

        public SnakesandLadders(string Game, int token)
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
