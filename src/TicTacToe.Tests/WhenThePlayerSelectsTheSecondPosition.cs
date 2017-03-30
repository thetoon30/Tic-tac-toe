using NUnit.Framework;
using System;
using System.Linq;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class When_The_Player_Selects_The_Second_Position
    {
        [Test]
        public void It_Should_Put_Their_Choice_In_The_Second_Position()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.ChoosePosition(2);
            var position = game.GetPosition(2);

            //Assert
            Assert.AreEqual('X', position);
        }
    }
}
