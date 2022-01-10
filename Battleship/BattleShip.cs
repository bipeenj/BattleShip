using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class BattleShip : IShip
    {
        public int NoOfPositions { get; set; }
        public string Name { get; set; }
        public Tuple<int, int> StartPosition { get; set; }
        public Tuple<int, int> EndPosition { get; set; }
        public IList<Tuple<int, int>> HitPositions { get; set; }

        public bool DidSunk()
        {
            bool result = true;
            int X = StartPosition.Item1;
            int Y= StartPosition.Item2;
            
            if(StartPosition.Item1==EndPosition.Item1)
            {
                while(Y<=EndPosition.Item2)
                {
                    result = result && HitPositions.Contains(new Tuple<int, int>(X, Y));
                    Y += 1;
                }
            }
            else if(StartPosition.Item2 == EndPosition.Item2)
            {
                while (X <= EndPosition.Item1)
                {
                    result = result && HitPositions.Contains(new Tuple<int, int>(X, Y));
                    X += 1;
                }
            }
            return result;
        }

        public IStatus IsHit(int XPOS, int YPOS)
        {
            IStatus result = new Status();
            int X = StartPosition.Item1;
            int Y = StartPosition.Item2;

            if (StartPosition.Item1 == EndPosition.Item1)
            {
                if (XPOS==X && YPOS >=Y && YPOS<=EndPosition.Item2 )
                {
                    result.HitCurrent = true;
                }
            }
            else if (StartPosition.Item2 == EndPosition.Item2)
            {
                if(YPOS==Y && XPOS >= X && XPOS<= EndPosition.Item1)
                {
                    result.HitCurrent = true;
                }
            }
            return result;
        }
    }
}
