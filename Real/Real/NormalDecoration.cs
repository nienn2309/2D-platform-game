using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real
{
    public class NormalDecation : Decoration
    {
        public NormalDecation(string name, string description, Image image, int x, int y) : base(name, description, image, x, y)
        {

        }
        public override void Draw(Graphics canvas)
        {
            if (Image != null)
            {
                canvas.DrawImage(Image, X, Y);
            }
        }
    }

    public class Willow : NormalDecation
    {
        public Willow(int x, int y) : base("Willow", "A willow tree decoration", Image.FromFile("Willow.png"), x, y)
        {

        }
    }

    public class Willow0 : NormalDecation
    {
        public Willow0(int x, int y) : base("Willow0", "A willow tree decoration", Image.FromFile("Willow0.png"), x, y)
        {

        }
    }


    public class Tree : NormalDecation
    {
        public Tree(int x, int y) : base("Tree", "A tree decoration", Image.FromFile("Tree.png"), x, y)
        {

        }
    }

    public class Bush : NormalDecation
    {
        public Bush(int x, int y) : base("Bush", "A bush for decoration purpose", Image.FromFile("Bush.png"), x, y)
        {

        }
    }

    public class Bush0 : NormalDecation
    {
        public Bush0(int x, int y) : base("Bush0", "A bush for decoration purpose", Image.FromFile("Bush0.png"), x, y)
        {

        }
    }

    public class Bush1 : NormalDecation
    {
        public Bush1(int x, int y) : base("Bush1", "A bush for decoration purpose", Image.FromFile("Bush1.png"), x, y)
        {

        }
    }

    public class Ridge : NormalDecation
    {
        public Ridge(int x, int y) : base("Ridge", "A ridge for decoration purpose", Image.FromFile("Ridge.png"), x, y)
        {

        }
    }

    public class Ridge0 : NormalDecation
    {
        public Ridge0(int x, int y) : base("Ridge0", "Another ridge for decoration purpose", Image.FromFile("Ridge0.png"), x, y)
        {

        }
    }

    public class Ridge1 : NormalDecation
    {
        public Ridge1(int x, int y) : base("Ridge1", "Another ridge for decoration purpose", Image.FromFile("Ridge1.png"), x, y)
        {

        }
    }

    public class PointerRight : NormalDecation
    {
        public PointerRight(int x, int y) : base("PointerRight", "A Pointer", Image.FromFile("PointerRight.png"), x, y)
        {

        }
    }

    public class PointerNorthRight : NormalDecation
    {
        public PointerNorthRight(int x, int y) : base("PointerNorthRight", "A Pointer", Image.FromFile("PointerNorthRight.png"), x, y)
        {

        }
    }

    public class Box : NormalDecation
    {
        public Box(int x, int y) : base("Box", "A Pointer", Image.FromFile("Box.png"), x, y)
        {

        }
    }
}
