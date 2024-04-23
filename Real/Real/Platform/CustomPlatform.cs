namespace Real
{
    public class Custom1 : EastWithCorner
    {
        private Image Corner1;
        private Image Corner2;

        public Custom1(int x, int y, int width, int height) : base(x, y, width, height)
        {
            Corner1 = Image.FromFile("TilesNorthRightCorner.png");
            Corner2 = Image.FromFile("CornerNorthRight.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / EastImage.Width;
            int repeatCountHeight = PB.Height / EastImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (i == repeatCountWidth - 1 && j == 0)
                    {
                        ChangeImage(Corner1);
                        canvas.DrawImage(Corner1, PB.Left + i * Corner1.Width, PB.Top + j * Corner1.Height);
                    }
                    else if (i == 1 && j == 0)
                    {
                        ChangeImage(Corner2);
                        canvas.DrawImage(Corner2, PB.Left + i * Corner2.Width, PB.Top + j * Corner2.Height);
                    }
                    else if (i == repeatCountWidth - 1 && j >= 0 && j <= repeatCountHeight - 1)
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

    public class Custom2 : EastWithCorner
    {
        private Image CornerC1;
        private Image CornerC2;
        private Image NorthImage;
        private Image SouthImage;
        public Custom2(int x, int y, int width, int height) : base(x, y, width, height)
        {
            CornerC1 = Image.FromFile("CornerNorthRight.png");
            CornerC2 = Image.FromFile("CornerSouthRight.png");
            NorthImage = Image.FromFile("TilesNorth.png");
            SouthImage = Image.FromFile("TilesSouth.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / EastImage.Width;
            int repeatCountHeight = PB.Height / EastImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (i == 2 && j == 0)
                    {
                        ChangeImage(CornerC1);
                        canvas.DrawImage(CornerC1, PB.Left + i * CornerC1.Width, PB.Top + j * CornerC1.Height);
                    }
                    else if (i == 2 && j == 1)
                    {
                        ChangeImage(CornerC2);
                        canvas.DrawImage(CornerC2, PB.Left + i * CornerC2.Width, PB.Top + j * CornerC2.Height);
                    }
                    else if(i == 3 && j == 0)
                    {
                        ChangeImage(NorthImage);
                        canvas.DrawImage(NorthImage, PB.Left + i * NorthImage.Width, PB.Top + j * NorthImage.Height);
                    }
                    else if (i == 3 && j == 1)
                    {
                        ChangeImage(SouthImage);
                        canvas.DrawImage(SouthImage, PB.Left + i * SouthImage.Width, PB.Top + j * SouthImage.Height);
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

    public class Custom3 : EastWithCorner
    {
        private Image CornerC2;
        public Custom3(int x, int y, int width, int height) : base(x, y, width, height)
        {
            CornerC2 = Image.FromFile("CornerSouthRight.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / EastImage.Width;
            int repeatCountHeight = PB.Height / EastImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (i == 2 && j == 0)
                    {
                        ChangeImage(EastImage);
                        canvas.DrawImage(EastImage, PB.Left + i * EastImage.Width, PB.Top + j * EastImage.Height);
                    }
                    else if (i == 1 && j == 1)
                    {
                        ChangeImage(CornerC2);
                        canvas.DrawImage(CornerC2, PB.Left + i * CornerC2.Width, PB.Top + j * CornerC2.Height);
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

    public class Custom4 : EastWithCorner
    {
        private Image CornerC1;
        private Image NorthImage;
        public Custom4(int x, int y, int width, int height) : base(x, y, width, height)
        {
            CornerC1 = Image.FromFile("CornerNorthRight.png");
            NorthImage = Image.FromFile("TilesNorth.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / EastImage.Width;
            int repeatCountHeight = PB.Height / EastImage.Height;

            for (int j = 0; j < repeatCountHeight; j++)
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (i == repeatCountWidth - 1 && j > 0 && j <= repeatCountHeight - 1)
                    {
                        ChangeImage(EastImage);
                        canvas.DrawImage(EastImage, PB.Left + i * EastImage.Width, PB.Top + j * EastImage.Height);
                    }
                    else if (i == repeatCountWidth - 1 && j == 0)
                    {
                        ChangeImage(Corner1);
                        canvas.DrawImage(Corner1, PB.Left + i * Corner1.Width, PB.Top + j * Corner1.Height);
                    }
                    else if (i == 1 && j == 0)
                    {
                        ChangeImage(CornerC1);
                        canvas.DrawImage(CornerC1, PB.Left + i * CornerC1.Width, PB.Top + j * CornerC1.Height);
                    }
                    else if(i == 2 && j == 0)
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

    public class Custom5 : EastWithCorner
    {
        private Image CornerC1;
        private Image NorthImage;
        public Custom5(int x, int y, int width, int height) : base(x, y, width, height)
        {
            CornerC1 = Image.FromFile("CornerNorthRight.png");
            NorthImage = Image.FromFile("TilesNorth.png");
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
                    else if (i == 3 && j == 0)
                    {
                        ChangeImage(CornerC1);
                        canvas.DrawImage(CornerC1, PB.Left + i * CornerC1.Width, PB.Top + j * CornerC1.Height);
                    }
                    else if (i == 4 && j == 0)
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

    public class Custom6 : EastWithCorner
    {
        private Image CornerC1;
        public Custom6(int x, int y, int width, int height) : base(x, y, width, height)
        {
            CornerC1 = Image.FromFile("CornerNorthRight.png");
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
                    else if (i == 5 && j == 0)
                    {
                        ChangeImage(CornerC1);
                        canvas.DrawImage(CornerC1, PB.Left + i * CornerC1.Width, PB.Top + j * CornerC1.Height);
                    }
                    else if (i == 6 && j == 3)
                    {
                        ChangeImage(CornerC1);
                        canvas.DrawImage(CornerC1, PB.Left + i * CornerC1.Width, PB.Top + j * CornerC1.Height);
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

    public class Custom7 : NorthWithCorner
    {
        private Image CornerC3;
        private Image EastImage;
        private Image WestImage;
        public Custom7(int x, int y, int width, int height) : base(x, y, width, height)
        {
            CornerC3 = Image.FromFile("CornerNorthLeft.png");
            EastImage = Image.FromFile("TilesEast.png");
            WestImage = Image.FromFile("TilesWest.png");
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
                    else if(i == repeatCountWidth - 1 && j <= repeatCountHeight - 1 && j > 0)
                    {
                        ChangeImage(EastImage);
                        canvas.DrawImage(EastImage, PB.Left + i * EastImage.Width, PB.Top + j * EastImage.Height);
                    }
                    else if (i == 0 && j == 1)
                    {
                        ChangeImage(WestImage);
                        canvas.DrawImage(WestImage, PB.Left + i * WestImage.Width, PB.Top + j * WestImage.Height);
                    }
                    else if (i == 0 && j == 2)
                    {
                        ChangeImage(CornerC3);
                        canvas.DrawImage(CornerC3, PB.Left + i * CornerC3.Width, PB.Top + j * CornerC3.Height);
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

    public class Custom8 : NorthWithCorner
    {
        private Image EastImage;
        private Image WestImage;
        public Custom8(int x, int y, int width, int height) : base(x, y, width, height)
        {
            EastImage = Image.FromFile("TilesEast.png");
            WestImage = Image.FromFile("TilesWest.png");
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
                    else if (i == repeatCountWidth - 1 && j <= repeatCountHeight - 1 && j > 0)
                    {
                        ChangeImage(EastImage);
                        canvas.DrawImage(EastImage, PB.Left + i * EastImage.Width, PB.Top + j * EastImage.Height);
                    }
                    else if (i == 0 && j <= repeatCountHeight - 1 && j > 0)
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
}
