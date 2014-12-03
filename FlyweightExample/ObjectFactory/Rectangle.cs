using System.Drawing;

namespace ObjectFactory
{
    public class Rectangle
    {
        public Bitmap Picture { get; set; }//intrinsic
        public int X { get; set; }//extrinsic
        public int Y { get; set; }//extrinsic

        public Rectangle(Bitmap b)
        {
            Picture = b;
        }
    }
}