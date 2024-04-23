namespace Real
{
    public class AnimatedObject : InteractableObject
    {
        public AnimatedObject(string name, string description, Image image, int x, int y) : base(name, description, image, x, y)
        {
            
        }

        public void SetUpAnimation()
        {
            ImageAnimator.Animate(Image, this.OnFrameChangedHandler);
        }

        private void OnFrameChangedHandler(object? sender, EventArgs e)
        {
            ImageAnimator.UpdateFrames(Image);
        }
    }

    public class Flag : AnimatedObject
    {
        public Flag(int x, int y) : base("Flag", "A flag for decoration purpose", Image.FromFile("Flag.gif"), x, y)
        {
            SetUpAnimation();
        }

        public override void Interact()
        {

        }
    }

    public class Coin : AnimatedObject
    {
        internal bool isInteracted = false;
        internal bool touchedByPlayer = false;
        public Coin(int x, int y) : base("Coin", "A Coin", Image.FromFile("Coin.gif"), x, y)
        {
            SetUpAnimation();
        }
        public override void Interact()
        {
            isInteracted = true;
            touchedByPlayer = true;
        }
    }

    public class Chest : AnimatedObject
    {
        protected bool isInteracted = false;
        public Chest(int x, int y) : base("Chest", "A Chest", Image.FromFile("Chest.gif"), x, y)
        {
            
        }

        public void Interact(List<InteractableObject> objectsToAdd)
        {
            if (!isInteracted)
            {
                isInteracted = true;
                SetUpAnimation();


                Coin newCoin = new Coin(X, Y);
                objectsToAdd.Add(newCoin);
            }
        }
    }
}
