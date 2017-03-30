using NUnit.Framework;
using System;
using System.Linq;
using TicTacToe;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class When_The_Player_Goes_First
    {
        [Test]
        public void It_Should_Put_Their_Choice_In_The_Selected_Position()
        {
            //Arrange
            var game = new Game();

            //Act
            game.ChoosePosition(1);
            var position = game.GetPosition(1);

            //Assert
            Assert.AreEqual('X', position);
        }

        [Test]
        public void It_Should_Make_The_Next_Move()
        {
            
        }
    }
}
