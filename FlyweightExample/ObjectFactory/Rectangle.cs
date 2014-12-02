using System.Drawing;

namespace ObjectFactory
{
    public class Rectangle
    {
        public Bitmap Picture { get; set; }//intrinsic
        public int X { get; set; }//extrinsic
        public int Y { get; set; }//extrinsic

        public Rectangle(Bitmap b,int x, int y)
        {
            Picture = b;
            X = x;
            Y = y;
        }
    }
}