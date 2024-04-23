namespace Real
{
    public class Decoration : GameObject
    {
        protected Image image;

        public Image Image
        {
            get { return image; }
            private set
            {
                image = value;
                Width = image.Width;
                Height = image.Height;
            }
        }

        public int X { get; private set; }
        public virtual int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; protected set; }

        public Decoration(string name, string description, Image image, int x, int y) : base(name, description)
        {
            Image = image;
            X = x;
            Y = y;
        }

        public void ChangeImage(string newImage)
        {
            Image = Image.FromFile(newImage);
        }
    }
}
