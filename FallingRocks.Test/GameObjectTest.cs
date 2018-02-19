namespace FallingRocks.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class GameObjectTest
    {
        [TestMethod]
        public void Constructor_WithZeroX_SetsX()
        {
            var x = 0;
            var y = 0;

            var gameObject = new GameObject(x, y);

            Assert.AreEqual(x, gameObject.X, "GameObject.X is not set.");
        }

        [TestMethod]
        public void Constructor_WithZeroY_SetsY()
        {
            var x = 0;
            var y = 0;

            var gameObject = new GameObject(x, y);

            Assert.AreEqual(y, gameObject.Y, "GameObject.Y is not set.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "GameObject.X must be equal or greater than 0. ArgumentException must be thrown otherwise.")]
        public void Constructor_WithNegativeX_ThrowsArgumentException()
        {
            var x = -1;
            var y = 0;

            var gameObject = new GameObject(x, y);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "GameObject.Y must be equal or greater than 0. ArgumentException must be thrown otherwise.")]
        public void Constructor_WithNegativeY_ThrowsArgumentException()
        {
            var x = 0;
            var y = -1;

            var gameObject = new GameObject(x, y);
        }
    }
}
