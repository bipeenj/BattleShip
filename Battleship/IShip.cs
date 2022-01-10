using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public interface IShip
    {
        int NoOfPositions { get; set; }
        String Name { get; set; }
        IStatus IsHit(int XPOS, int YPOS);
        Tuple<int, int> StartPosition { get; set; }
        Tuple<int, int> EndPosition { get; set; }
        IList<Tuple<int, int>> HitPositions { get; set; }
        bool DidSunk();
    }
}
