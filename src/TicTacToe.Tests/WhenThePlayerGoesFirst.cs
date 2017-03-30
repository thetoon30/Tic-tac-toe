using System;
using NUnit.Framework;
using TicTacToe;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class When_The_Player_Goes_First
    {
        [Test]
        public void It_Should_Put_Their_Choice_In_The_Selected_Position()
        {
            var game = new Game();
            game.ChoosePosition(1);
            Assert.AreEqual('X', game.GetPosition(1));
        }
    }
}
