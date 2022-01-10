using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public interface IStatus
    {
        bool HasAllshipsSunk { get; set; }
        bool HitTheShip { get; set; }
        bool HitCurrent { get; set; }
        bool ShipSunk { get; set; }
    }
}
