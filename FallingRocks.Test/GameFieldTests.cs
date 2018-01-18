namespace FallingRocks.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class GameFieldTests
    {
        [TestMethod]
        public void Constructor_WhenCalledWithPositiveSize_InstantiatesGameField()
        {
            var positiveWidth = 10;
            var positiveHeight = 10;

            var gameField = new GameField(positiveWidth, positiveHeight);

            Assert.IsNotNull(gameField, "gameField must not be null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "GameField.Width must be greater than 0. ArgumentException must be thrown otherwise.")]
        public void Constructor_WhenCalledWithNegativeWidth_ThrowsArgumentException()
        {
            var negativeWidth = -10;
            var positiveHeight = 10;

            var gameField = new GameField(negativeWidth, positiveHeight);
        }
    }
}
