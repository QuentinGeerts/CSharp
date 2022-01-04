using System;

namespace _07_HeritageDissimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Classe de base --");
            ClasseDeBase cdb = new ClasseDeBase();
            cdb.MethodeRedefinie();
            cdb.MethodeDissimulee();

            Console.WriteLine("-- Classe dérivée--");
            ClasseDerivee cd = new ClasseDerivee();
            cd.MethodeRedefinie();
            cd.MethodeDissimulee();

            Console.WriteLine("-- Polymorphisme --");
            ClasseDeBase cdbd = new ClasseDerivee(); // polymorphisme
            cdbd.MethodeRedefinie();
            cdbd.MethodeDissimulee();
        }
    }
}
