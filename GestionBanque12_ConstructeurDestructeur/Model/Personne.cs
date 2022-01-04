using System;

namespace GestionBanque.Model
{
    class Personne
    {

        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateNaiss { get; private set; }
        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
            Console.WriteLine($"Personne créée : {Nom} {Prenom} {DateNaiss}");
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} né le {DateNaiss}";
        }
    }
}
