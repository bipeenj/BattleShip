using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Board : IBoard
    {
        public IDictionary<Tuple<int, int>, bool> HitOrMiss { get ; set ; }
    }
}
