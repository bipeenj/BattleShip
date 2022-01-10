using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public interface IPlayer
    {
        string Name { get; set; }
        IList<IShip> Ships { get; set; }
        IList<IBoard> Boards { get; set; }

        bool AddShip(Tuple<int, int> startPos, Tuple<int, int> endPos);
        bool AllSunk();

    }
}
