using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelFactory;
using Rectangle = PixelFactory.Rectangle;

namespace ObjectFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pixelListFlyweight = new List<Rectangle>();
            var pixelListNormal = new List<Rectangle>();
            
            var myPixelFactory = new PixelFactory.PixelFactory();

            var rnd = new Random();
            var s = new Stopwatch();

            
                s.Start();
                for (int i = 0; i < 260; i++)
                {
                    //var bitmap = myPixelFactory.GetBitmap((PixelColor) rnd.Next(3));
                    //pixelListFlyweight.Add(new Rectangle(bitmap, rnd.Next(100), rnd.Next(100)));
                    pixelListNormal.Add(new Rectangle(new Bitmap("../../images/red.bmp"), rnd.Next(100), rnd.Next(100)));
                }
                s.Stop();
                //pixelListFlyweight.Clear();
                //pixelListNormal.Clear();
                
                //myPixelFactory.Reset();
                Console.WriteLine(s.Elapsed.Milliseconds);
                s.Reset();
            
            
            //Console.WriteLine(myPixelFactory.ObjectsCount);
            Console.ReadKey();
        }
    }
}
