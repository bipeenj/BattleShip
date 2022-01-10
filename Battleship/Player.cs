using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public class Player: IPlayer
    {
        public Player(string nameIn)
        {
            Ships = new List<IShip>();
            Boards = new List<IBoard>();
            Name = nameIn;
        }
        public IList<IShip> Ships { get; set; }
        public IList<IBoard> Boards { get ; set; }
        public string Name { get; set; }

        public bool AddShip(Tuple<int, int> startPos, Tuple<int, int> endPos)
        {
            bool result = true;
            foreach(IShip sh in Ships)
            {
                int X = startPos.Item1;
                int Y = startPos.Item2;
                if(startPos.Item1==endPos.Item1)
                {
                    while(result && Y <= endPos.Item2)
                    {
                        result = result && !sh.IsHit(X,Y).HitCurrent;
                        Y += 1;
                    }
                }
                else if(startPos.Item2== endPos.Item2)
                {
                    while (result && X <= endPos.Item1)
                    {
                        result = result && !sh.IsHit(X, Y).HitCurrent;
                        X += 1;
                    }
                }
                
            }
            if (result && startPos.Item1 > 0 && startPos.Item1 < 11 && endPos.Item1 > 0 && endPos.Item1 < 11 &&
                startPos.Item2 > 0 && startPos.Item2 < 11 && endPos.Item2 > 0 && endPos.Item2 < 11 &&
                (startPos.Item1 == endPos.Item1 || startPos.Item2 == endPos.Item2))
            {
                Ships.Add(new BattleShip {
                    StartPosition = startPos,
                    EndPosition = endPos
                });
            }
            else
                result = false;
                return result;
        }

        public bool AllSunk()
        {
            bool result = true;
            foreach(IShip ship in Ships)
            {
                result = result && ship.DidSunk();
            }
            return result;
        }
    }
}
