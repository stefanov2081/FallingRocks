namespace FallingRocks
{
    using System;

    public class GameField
    {
        private int width;
        private int height;

        public GameField(int width, int height)
        {
            Width = width;
            Height = height;
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

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height must be greater than 0.");
                }

                height = value;
            }
        }
    }
}
