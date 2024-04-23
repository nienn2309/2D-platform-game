namespace Real
{
    public class West : Platform
    {
        protected Image WestImage;
        protected Image InsideImage;

        public West(int x, int y, int width, int height) : base("ground", "solid ground", x, y, width, height)
        {
            WestImage = Image.FromFile("TilesWest.png");
            InsideImage = Image.FromFile("TilesInside.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / WestImage.Width;
            int repeatCountHeight = PB.Height / WestImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (i == 0 && j >= 0 && j <= repeatCountHeight - 1)
                    {
                        ChangeImage(WestImage);
                        canvas.DrawImage(WestImage, PB.Left + i * WestImage.Width, PB.Top + j * WestImage.Height);
                    }
                    else
                    {
                        ChangeImage(InsideImage);
                        canvas.DrawImage(InsideImage, PB.Left + i * InsideImage.Width, PB.Top + j * InsideImage.Height);
                    }
                }
            }
        }
    }

    public class East : Platform
    {
        protected Image EastImage;
        protected Image InsideImage;

        public East(int x, int y, int width, int height) : base("ground", "solid ground", x, y, width, height)
        {
            EastImage = Image.FromFile("TilesEast.png");
            InsideImage = Image.FromFile("TilesInside.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / EastImage.Width;
            int repeatCountHeight = PB.Height / EastImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (i == repeatCountWidth - 1 && j >= 0 && j <= repeatCountHeight - 1)
                    {
                        ChangeImage(EastImage);
                        canvas.DrawImage(EastImage, PB.Left + i * EastImage.Width, PB.Top + j * EastImage.Height);
                    }
                    else
                    {
                        ChangeImage(InsideImage);
                        canvas.DrawImage(InsideImage, PB.Left + i * InsideImage.Width, PB.Top + j * InsideImage.Height);
                    }
                }
            }
        }
    }

    public class North : Platform
    {
        protected Image NorthImage;
        protected Image InsideImage;

        public North(int x, int y, int width, int height) : base("ground", "solid ground", x, y, width, height)
        {
            NorthImage = Image.FromFile("TilesNorth.png");
            InsideImage = Image.FromFile("TilesInside.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / NorthImage.Width;
            int repeatCountHeight = PB.Height / NorthImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (j == 0 && i >= 0 && i <= repeatCountWidth - 1)
                    {
                        ChangeImage(NorthImage);
                        canvas.DrawImage(NorthImage, PB.Left + i * NorthImage.Width, PB.Top + j * NorthImage.Height);
                    }
                    else
                    {
                        ChangeImage(InsideImage);
                        canvas.DrawImage(InsideImage, PB.Left + i * InsideImage.Width, PB.Top + j * InsideImage.Height);
                    }
                }
            }
        }
    }

    public class South : Platform
    {
        protected Image SouthImage;
        protected Image InsideImage;

        public South(int x, int y, int width, int height) : base("ground", "solid ground", x, y, width, height)
        {
            SouthImage = Image.FromFile("TilesSouth.png");
            InsideImage = Image.FromFile("TilesInside.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / SouthImage.Width;
            int repeatCountHeight = PB.Height / SouthImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (j == repeatCountHeight - 1 && i >= 0 && i <= repeatCountWidth - 1)
                    {
                        ChangeImage(SouthImage);
                        canvas.DrawImage(SouthImage, PB.Left + i * SouthImage.Width, PB.Top + j * SouthImage.Height);
                    }
                    else
                    {
                        ChangeImage(InsideImage);
                        canvas.DrawImage(InsideImage, PB.Left + i * InsideImage.Width, PB.Top + j * InsideImage.Height);
                    }
                }
            }
        }
    }
}
