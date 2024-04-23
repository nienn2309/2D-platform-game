namespace Real
{
    public class Platform : GameObject
    {
        public PictureBox PB { get; private set; }

        public Platform(string name, string description, int x, int y, int width, int height) : base(name, description)
        {
            PB = new PictureBox();
            PB.Left = x;
            PB.Top = y;
            PB.Width = width;
            PB.Height = height;
        }

        public void ChangeImage(Image newImage)
        {
            PB.Image = newImage;
        }

        public virtual void Draw(Graphics canvas)
        {
            
        }
    }
}
