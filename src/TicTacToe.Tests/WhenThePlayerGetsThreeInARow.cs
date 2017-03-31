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
            //Arrange
            Game game = new Game();

            //Act
            game.ChoosePosition(1);
            game.ChoosePosition(2);
            string message = game.ChoosePosition(3);

            //Assert
            Assert.AreEqual("Player wins!", message);
        }

        [Test]
        public void It_Should_Announce_The_Game_As_The_Winner()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.ChoosePosition(4);
            game.ChoosePosition(6);
            string message = game.ChoosePosition(8);

            //Assert
            Assert.AreEqual("Game wins.", message);
        }
    }
}
