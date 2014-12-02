using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelFactory
{
    public enum PixelColor
    {
        Red,
        Green,
        Blue
    }

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

    public class PixelFactory
    {
        public int ObjectsCount = 0;
        private Dictionary<PixelColor, Bitmap> _pixelColors;

        public void Reset()
        {
            _pixelColors.Clear();
        }

        public Bitmap GetBitmap(PixelColor instanceType)
        {
            if (_pixelColors == null)
                _pixelColors = new Dictionary<PixelColor, Bitmap>();

            if (_pixelColors.ContainsKey(instanceType))
                return _pixelColors[instanceType];

            switch (instanceType)
            {
                case PixelColor.Red:
                    {
                        _pixelColors.Add(instanceType, new Bitmap("../../images/red.bmp"));
                        ObjectsCount++;
                        break;
                    }

                case PixelColor.Green:
                    {
                        _pixelColors.Add(instanceType, new Bitmap("../../images/green.bmp"));
                        ObjectsCount++;
                        break;
                    }

                case PixelColor.Blue:
                    {
                        _pixelColors.Add(instanceType, new Bitmap("../../images/blue.bmp"));
                        ObjectsCount++;
                        break;
                    }
            }

            return _pixelColors[instanceType];
        }

    }

}
