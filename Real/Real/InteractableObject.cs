using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static Real.InteractableObject;

namespace Real
{
    public class InteractableObject : Decoration, IInteractable
    {
        public InteractableObject(string name, string description, Image image, int x, int y) : base(name, description, image, x, y)
        {
        }
        internal bool DetectCollision(int object1X, int object1Y, int object1Width, int object1Height, int object2X, int object2Y, int object2Width, int object2Height)
        {
            if (object1X + object1Width <= object2X || object1X >= object2X + object2Width || object1Y + object1Height <= object2Y || object1Y >= object2Y + object2Height)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public virtual void Interact()
        {
            
        }

        internal bool DetectAvailableZone(int pX, int oX, int oWidth)
        {
            if (pX >= oX - oWidth / 4 && pX <= oX + oWidth / 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool DetectAvailableHeight(int pY,  int oY, int oHeight)
        {
            if(pY <= oY -  oHeight / 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class Ladder : InteractableObject
    {
        private int frameHeight;

        public Ladder(int x, int y, int height) : base("Ladder", "A Ladder", Image.FromFile("Ladder.png"), x, y)
        {
            Height = height;
            frameHeight = Height / image.Height;
        }

        public override void Draw(Graphics canvas)
        {
            if (Image != null)
            {
                for (int i = 0; i < frameHeight; i++)
                {
                    int frameY = Y + i * image.Height;
                    canvas.DrawImage(Image, X, frameY);
                }
            }
        }

    }
}
