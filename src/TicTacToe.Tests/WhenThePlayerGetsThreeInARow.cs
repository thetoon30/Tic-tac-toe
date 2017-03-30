using NUnit.Framework;
using System;
using System.Linq;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class When_The_Player_Gets_Three_In_A_Row
    {
        [Test]
        public void It_Should_Announce_The_Player_As_The_Winner()
        {
            Game game = new Game();
            game.ChoosePosition(1);
            game.ChoosePosition(2);
            string message = game.ChoosePosition(3);
            Assert.AreEqual("Player wins!", message);
        }
    }
}
