using System;

namespace _07_HeritageDissimulation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("-- Classe de base --");
            var cdb = new ClasseDeBase();
            cdb.MethodeRedefinie();
            cdb.MethodeDissimulee();

            Console.WriteLine("-- Classe dérivée--");
            var cd = new ClasseDerivee();
            cd.MethodeRedefinie();
            cd.MethodeDissimulee();

            Console.WriteLine("-- Polymorphisme --");
            ClasseDeBase cdbd = new ClasseDerivee(); // polymorphisme
            cdbd.MethodeRedefinie();
            cdbd.MethodeDissimulee();
        }
    }
}