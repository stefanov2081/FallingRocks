using System;

namespace FallingRocks
{
    public class GameField
    {
        private int width;
        private int height;

        public GameField(int width, int height)
        {
            Width = width;
            this.height = height;
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be greater than 0.");
                }

                width = value;
            }
        }
    }
}
