using System.Collections.Generic;
using System.Drawing;

namespace ObjectFactory
{
    public enum PixelColor
    {
        Red,
        Green,
        Blue
    }

    public class RectangleFactory
    {
        public int ObjectsCount = 0;
        private Dictionary<PixelColor, Rectangle> _rectangles;

        public void Reset()
        {
            _rectangles.Clear();
        }

        public Rectangle GetRectangle(PixelColor instanceType)
        {
            if (_rectangles == null)
                _rectangles = new Dictionary<PixelColor, Rectangle>();

            if (_rectangles.ContainsKey(instanceType))
                return _rectangles[instanceType];

            switch (instanceType)
            {
                case PixelColor.Red:
                    {
                        _rectangles.Add(instanceType, new Rectangle(new Bitmap("../../images/red.bmp")));
                        ObjectsCount++;
                        break;
                    }

                case PixelColor.Green:
                    {
                        _rectangles.Add(instanceType, new Rectangle(new Bitmap("../../images/green.bmp")));
                        ObjectsCount++;
                        break;
                    }

                case PixelColor.Blue:
                    {
                        _rectangles.Add(instanceType, new Rectangle(new Bitmap("../../images/blue.bmp")));
                        ObjectsCount++;
                        break;
                    }
            }
            return _rectangles[instanceType];
        }
    }
}
