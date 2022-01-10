using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public interface IBoard
    {
        IDictionary<Tuple<int, int>, bool> HitOrMiss { get; set; }
    }
}
