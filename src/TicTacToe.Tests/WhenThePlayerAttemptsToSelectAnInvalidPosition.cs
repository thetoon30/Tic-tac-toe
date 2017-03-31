using NUnit.Framework;
using System;
using System.Linq;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class When_The_Player_Attempts_To_Select_An_Invalid_Position
    {
        [Test]
        public void It_Should_Tell_The_Player_The_Position_Is_Invalid()
        {
            //Arrange
            var game = new Game();

            //Act
            string message = game.ChoosePosition(10);

            //Assert
            Assert.AreEqual("That spot is invalid!", message);
        }
    }
}
