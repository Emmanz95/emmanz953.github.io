using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
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

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

