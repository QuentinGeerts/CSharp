using System;

namespace GestionBanque.Model
{
    internal class Personne
    {
        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
            Console.WriteLine($"Personne créée : {Nom} {Prenom} {DateNaiss}");
        }

        public string Nom { get; }
        public string Prenom { get; }
        public DateTime DateNaiss { get; }

        public override string ToString()
        {
            return $"{Nom} {Prenom} né le {DateNaiss}";
        }
    }
}