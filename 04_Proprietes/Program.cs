using System;

namespace _04_Proprietes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var quentin = new Personne { Nom = "Geerts", Prenom = "Quentin", DateNaiss = new DateTime(1996, 04, 03) };
            Console.WriteLine($"{quentin.Nom} {quentin.Prenom} {quentin.Age}");

            quentin.Marcher();
            quentin.DireBonjour();
        }
    }
}