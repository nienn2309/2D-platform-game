namespace Real
{
    public class WestWithCorner : West
    {
        private Image Corner1;
        private Image Corner2;

        public WestWithCorner(int x, int y, int width, int height) : base(x, y, width, height)
        {
            Corner1 = Image.FromFile("TilesNorthLeftCorner.png");
            Corner2 = Image.FromFile("TilesSouthLeftCorner.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / WestImage.Width;
            int repeatCountHeight = PB.Height / WestImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (i == 0 && j == 0)
                    {
                        ChangeImage(Corner1);
                        canvas.DrawImage(Corner1, PB.Left + i * Corner1.Width, PB.Top + j * Corner1.Height);
                    }
                    else if (j == repeatCountHeight - 1 && i == 0)
                    {
                        ChangeImage(Corner2);
                        canvas.DrawImage(Corner2, PB.Left + i * Corner2.Width, PB.Top + j * Corner2.Height);
                    }
                    else if (i == 0 && j > 0 && j < repeatCountHeight - 1)
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

    public class EastWithCorner : East
    {
        protected Image Corner1;
        protected Image Corner2;

        public EastWithCorner(int x, int y, int width, int height) : base(x, y, width, height)
        {
            Corner1 = Image.FromFile("TilesNorthRightCorner.png");
            Corner2 = Image.FromFile("TilesSouthRightCorner.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / EastImage.Width;
            int repeatCountHeight = PB.Height / EastImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (i == repeatCountWidth - 1 && j > 0 && j < repeatCountHeight - 1)
                    {
                        ChangeImage(EastImage);
                        canvas.DrawImage(EastImage, PB.Left + i * EastImage.Width, PB.Top + j * EastImage.Height);
                    }
                    else if (i == repeatCountWidth - 1 && j == 0)
                    {
                        ChangeImage(Corner1);
                        canvas.DrawImage(Corner1, PB.Left + i * Corner1.Width, PB.Top + j * Corner1.Height);
                    }
                    else if (j == repeatCountHeight - 1 && i == repeatCountWidth - 1)
                    {
                        ChangeImage(Corner2);
                        canvas.DrawImage(Corner2, PB.Left + i * Corner2.Width, PB.Top + j * Corner2.Height);
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

    public class NorthWithCorner : North
    {
        protected Image Corner1;
        protected Image Corner2;

        public NorthWithCorner(int x, int y, int width, int height) : base(x, y, width, height)
        {
            Corner1 = Image.FromFile("TilesNorthRightCorner.png");
            Corner2 = Image.FromFile("TilesNorthLeftCorner.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / NorthImage.Width;
            int repeatCountHeight = PB.Height / NorthImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (j == 0 && i > 0 && i < repeatCountWidth - 1)
                    {
                        ChangeImage(NorthImage);
                        canvas.DrawImage(NorthImage, PB.Left + i * NorthImage.Width, PB.Top + j * NorthImage.Height);
                    }
                    else if (i == repeatCountWidth - 1 && j == 0)
                    {
                        ChangeImage(Corner1);
                        canvas.DrawImage(Corner1, PB.Left + i * Corner1.Width, PB.Top + j * Corner1.Height);
                    }
                    else if (i == 0 && j == 0)
                    {
                        ChangeImage(Corner2);
                        canvas.DrawImage(Corner2, PB.Left + i * Corner2.Width, PB.Top + j * Corner2.Height);
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

    public class SouthWithCorner : South
    {
        private Image Corner1;
        private Image Corner2;

        public SouthWithCorner(int x, int y, int width, int height) : base(x, y, width, height)
        {
            Corner1 = Image.FromFile("TilesSouthRightCorner.png");
            Corner2 = Image.FromFile("TilesSouthLeftCorner.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / SouthImage.Width;
            int repeatCountHeight = PB.Height / SouthImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (j == repeatCountHeight - 1 && i > 0 && i < repeatCountWidth - 1)
                    {
                        ChangeImage(SouthImage);
                        canvas.DrawImage(SouthImage, PB.Left + i * SouthImage.Width, PB.Top + j * SouthImage.Height);
                    }
                    else if (j == repeatCountHeight - 1 && i == repeatCountWidth - 1)
                    {
                        ChangeImage(Corner1);
                        canvas.DrawImage(Corner1, PB.Left + i * Corner1.Width, PB.Top + j * Corner1.Height);
                    }
                    else if (j == repeatCountHeight - 1 && i == 0)
                    {
                        ChangeImage(Corner2);
                        canvas.DrawImage(Corner2, PB.Left + i * Corner2.Width, PB.Top + j * Corner2.Height);
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
