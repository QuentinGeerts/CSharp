using System;

namespace _04_Proprietes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne quentin = new Personne() { Nom = "Geerts", Prenom = "Quentin", DateNaiss = new DateTime(1996, 04, 03) };
            Console.WriteLine($"{quentin.Nom} {quentin.Prenom} {quentin.Age}");

            quentin.Marcher();
            quentin.DireBonjour();
        }
    }
}
