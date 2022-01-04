using System;

namespace _11_Interfaces
{
    class Point : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Display()
        {
            Console.WriteLine($"[{X}:{Y}]");
        }

        public void Draw()
        {
            Console.WriteLine("Dessine le point");
        }
    }
}
