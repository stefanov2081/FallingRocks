namespace FallingRocks.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class GameFieldTest
    {
        int positiveWidth;
        int positiveHeight;
        int negativeWidth;
        int negativeHeight;

        [TestInitialize]
        public void SetUp()
        {
            positiveWidth = 10;
            positiveHeight = 10;
            negativeWidth = -10;
            negativeHeight = -10;
        }

        public void TearDown()
        {
        }

        [TestMethod]
        public void Constructor_WithPositiveSize_InstantiatesGameField()
        {
            var gameField = new GameField(positiveWidth, positiveHeight);

            Assert.IsNotNull(gameField, "gameField must not be null");
        }

        [TestMethod]
        public void Constructor_WithPositiveSize_SetsSize()
        {
            var gameField = new GameField(positiveWidth, positiveHeight);

            Assert.AreEqual(positiveWidth, gameField.Width, "GameField.Width is not set.");
            Assert.AreEqual(positiveHeight, gameField.Height, "GameField.Height is not set.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "GameField.Width must be greater than 0. ArgumentException must be thrown otherwise.")]
        public void Constructor_WithNegativeWidth_ThrowsArgumentException()
        {
            var gameField = new GameField(negativeWidth, positiveHeight);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "GameField.Height must be greater than 0. ArgumentException must be thrown otherwise.")]
        public void Constructor_WithNegativeHeight_ThrowsArgumentException()
        {
            var gameField = new GameField(positiveWidth, negativeHeight);
        }
    }
}
