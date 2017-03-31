using NUnit.Framework;
using System;
using System.Linq;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class When_the_player_attempts_to_select_an_occupied_position
    {
        [Test]
        public void It_Should_Tell_The_Player_The_Position_Is_Occupied()
        {
            //Arrange
            var game = new Game();

            //Act
            game.ChoosePosition(2);
            string message = game.ChoosePosition(1);

            //Assert
            Assert.AreEqual("That spot is taken!", message);
        }
    }
}
