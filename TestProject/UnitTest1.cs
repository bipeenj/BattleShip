using Battleship;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPlayersCreation()
        {
            Game game = new Game();

            Assert.IsNotEmpty(game.Players);
        }
        [Test]
        public void TestAddShip()
        {
            Game game = new Game();
            foreach(IPlayer pl in  game.Players)
            {
                bool result = pl.AddShip(new System.Tuple<int, int>(10, 10), new System.Tuple<int, int>(10, 15));
                Assert.IsFalse(result);
                result = pl.AddShip(new System.Tuple<int, int>(10, 5), new System.Tuple<int, int>(10, 10));
                Assert.IsTrue(result);
            }
            
        }
        [Test]
        public void TestHitShip()
        {
            Game game = new Game();
            var pl = game.Players[0];
            bool result = pl.AddShip(new System.Tuple<int, int>(10, 5), new System.Tuple<int, int>(10, 10));
            result = pl.Ships[0].IsHit(10, 8).HitCurrent;    
            Assert.IsTrue(result);
            result = pl.Ships[0].IsHit(5, 8).HitCurrent;
            Assert.IsFalse(result);

        }
    }
}