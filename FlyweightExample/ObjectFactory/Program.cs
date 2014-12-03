using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace ObjectFactory
{
    class Program
    {
        static readonly List<Rectangle> Rectangles = new List<Rectangle>();
        static readonly RectangleFactory BitmapFactory = new RectangleFactory();
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
                var rectangle = BitmapFactory.GetRectangle((PixelColor)Random.Next(3));
                rectangle.X = Random.Next(100);
                rectangle.Y = Random.Next(100);
                Rectangles.Add(rectangle);
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
                var rectangle = new Rectangle(new Bitmap("../../images/red.bmp"));
                rectangle.X = Random.Next(100);
                rectangle.Y = Random.Next(100);
                Rectangles.Add(rectangle);   
            }
            Stopwatch.Stop();
            Console.WriteLine(Stopwatch.Elapsed.Milliseconds);
            Stopwatch.Reset();
        }
    }
}
