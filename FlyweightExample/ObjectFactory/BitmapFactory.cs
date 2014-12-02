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

    public class BitmapFactory
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
