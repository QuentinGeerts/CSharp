using System;

namespace _10_ClassesStatiques
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var maClasse = new MaClasse();
            maClasse.X = 5;
            MaClasse.Y = "str";

            var maClasse1 = new MaClasse();
            maClasse1.X = 8;
            //maClasse1.Y = "str";
            //maClasse1.Addition(5, 5);

            Console.WriteLine(MaClasse.Addition(5.2, 5.0));

            Console.WriteLine(MaClasse.Y);
            Console.WriteLine(maClasse.X);
            Console.WriteLine(maClasse1.X);

            //ClasseStatique classeStatique = new ClasseStatique(); // Pas possible
            ClasseStatique.DireBonjour();
            ClasseStatique.X = 5;

            // Math = Classe statique
            Console.WriteLine(Math.PI);
        }
    }
}