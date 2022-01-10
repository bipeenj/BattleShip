using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Status : IStatus
    {
        public bool HasAllshipsSunk { get  ; set ; }
        public bool HitTheShip { get ; set ; }
        public bool ShipSunk { get ; set; }
        public bool HitCurrent { get ; set ; }
    }
}
