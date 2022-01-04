using System;

namespace _10_ClassesStatiques
{
    static class ClasseStatique /*: MaClasse*/ // est sealed par défaut
    {

        public /*static*/ const int Y = 5;
        public static void DireBonjour()
        {
            Console.WriteLine("Hello");
        }
        public static int X { get; set; }
    }
}
