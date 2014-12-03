using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace ObjectFactory
{
    class Program
    {
        static readonly List<Rectangle> Rectangles = new List<Rectangle>();
        static readonly BitmapFactory BitmapFactory = new BitmapFactory();
        static readonly Random Random = new Random();
        static readonly Stopwatch Stopwatch = new Stopwatch();

        static void Main()
        {
            Console.WriteLine("Flyweight code sample");
            Console.WriteLine("Please choose what implementation to use");
            Console.WriteLine("(1) Without flyweight");
            Console.WriteLine("(2) With flyweight");
            var choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    RunNotUsingFlyweight(250);
                    break;
                case "2":
                    RunUsingFlyweight(250);
                    break;
            }
        }

        public static void RunUsingFlyweight(int timesToRun)
        {
            Stopwatch.Start();
            for (int i = 0; i < timesToRun; i++)
            {
                var bitmap = BitmapFactory.GetBitmap((PixelColor)Random.Next(3));
                Rectangles.Add(new Rectangle(bitmap, Random.Next(100), Random.Next(100)));
            }
            Stopwatch.Stop();
            Console.WriteLine(Stopwatch.Elapsed.Milliseconds);
            Stopwatch.Reset();
        }

        public static void RunNotUsingFlyweight(int timesToRun)
        {
            Stopwatch.Start();
            for (int i = 0; i < timesToRun; i++)
            {
                Rectangles.Add(new Rectangle(new Bitmap("../../images/red.bmp"), Random.Next(100), Random.Next(100)));   
            }
            Stopwatch.Stop();
            Console.WriteLine(Stopwatch.Elapsed.Milliseconds);
            Stopwatch.Reset();
        }
    }
}
