using System;

namespace _A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var p1 = new Point(10, 20);
            Console.WriteLine($"{p1.X}, {p1.Y}");
            Console.WriteLine(p1.ToString());
        }
    }
    record Point(int X, int Y);
}
