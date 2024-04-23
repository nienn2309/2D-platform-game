namespace Real
{
    public class Line : Platform
    {
        private Image Block0;
        private Image Block1;
        private Image Block2;
        private Image Block3;
        public Line(int x, int y, int width, int height) : base("ground", "solid ground", x, y, width, height)
        {
            Block0 = Image.FromFile("FullTile0.png");
            Block1 = Image.FromFile("FullTile1.png");
            Block2 = Image.FromFile("FullTile2.png");
            Block3 = Image.FromFile("FullTile3.png");
        }

        public override void Draw(Graphics canvas)
        {
            int repeatCountWidth = PB.Width / Block0.Width;
            if (repeatCountWidth == 1 )
            {
                ChangeImage(Block0);
                canvas.DrawImage(Block0, PB.Left, PB.Top);
            }
            else
            {
                for (int i = 0; i < repeatCountWidth; i++)
                {
                    if (i == 0)
                    {
                        ChangeImage(Block1);
                        canvas.DrawImage(Block1, PB.Left + i * Block1.Width, PB.Top);
                    }
                    else if (i == repeatCountWidth - 1)
                    {
                        ChangeImage(Block3);
                        canvas.DrawImage(Block3, PB.Left + i * Block3.Width, PB.Top);
                    }
                    else
                    {
                        ChangeImage(Block2);
                        canvas.DrawImage(Block2, PB.Left + i * Block2.Width, PB.Top);
                    }
                }
            }
        }
    }
}
