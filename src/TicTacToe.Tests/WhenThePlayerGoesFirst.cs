using NUnit.Framework;
using System;
using System.Linq;
using TicTacToe;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class When_The_Player_Goes_First
    {
        Game _game;

        [SetUp]
        public void establish_context()
        {
            //Arrange
            _game = new Game();

            //Act
            _game.ChoosePosition(1);
        }

        [Test]
        public void It_Should_Put_Their_Choice_In_The_Selected_Position()
        {
            //Arrange phase is empty: testing static method to initialize

            //Act
            var position = _game.GetPosition(1);

            //Assert
            Assert.AreEqual('X', position);
        }

        [Test]
        public void It_Should_Make_The_Next_Move()
        {
            //Arrange phase is empty: testing static method to initialize

            //Act
            var isPosition = Enumerable.Range(1, 9)
                              .Any(position => _game.GetPosition(position)
                              .Equals('O'));

            //Assert
            Assert.IsTrue(isPosition);
        }
    }
}
