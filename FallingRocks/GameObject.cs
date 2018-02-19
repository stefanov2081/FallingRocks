using System;

namespace FallingRocks
{
    public class GameObject
    {
        private int x;
        private int y;

        public GameObject(int x, int y)
        {
            X = x;
            this.y = y;
        }

        public int X
        {
            get
            {
                return x;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

        }
    }
}
