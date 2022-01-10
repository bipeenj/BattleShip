using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public class Game
    {
        public IList<IPlayer> Players { get; set; }

        public Game()
        {
            Players = new List<IPlayer>();
            Players.Add(new Player("Player1"));
            Players.Add(new Player("Player2"));
        }


    }
}
