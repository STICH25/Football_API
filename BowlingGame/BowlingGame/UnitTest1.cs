using System;
using Xunit;

namespace BowlingGame
{
    public class BowlingGameTest
    {
        private readonly Game _game;
        public BowlingGameTest()
        {
            _game = new Game();
        }
        [Fact]
        public void ItExists()
        {
            
        }
        
        [Fact]
        public void ItHasScoreMethod()
        {
            int score = _game.Score();
        }

        [Fact]
        public void ItHasRolledMethod()
        {
            //Arrange
            for (int x = 0; x < 20; x++)
                _game.Roll(0);

            //Act
            int score = _game.Score();
            //Assert
            Assert.Equal(0, score);
        }

        [Fact]
        public void ItHasRolledMethod1()
        {
            //Arrange
            for (int x = 0; x < 20; x++)
                _game.Roll(0);

            //Act
            int score = _game.Score();
            //Assert
            Assert.Equal(0, score);
        }
    }
}
