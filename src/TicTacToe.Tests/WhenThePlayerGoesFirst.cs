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
            char[] positions = new char[2];
            bool gamePositionFound = false;

            for (int i = 0; i < 2; i++)
            {
                positions[i] = _game.GetPosition(i + 1);
            }

            for (int i = 0; i < 9; i++)
            {
                if (positions[i].Equals('O'))
                {
                    gamePositionFound = true;
                    break;
                }
            }

            //Assert
            Assert.IsTrue(gamePositionFound);
        }

        [Test]
        public void It_Should_Put_An_X_In_One_Of_The_Available_Positions()
        {
            //Arrange
            var game = new Game();

            //Act
            game.GoFirst();

            //Assert
            Assert.IsTrue(Enumerable.Range(1, 9)
                .Any(position => game.GetPosition(position).Equals('X')));
        }
    }
}
