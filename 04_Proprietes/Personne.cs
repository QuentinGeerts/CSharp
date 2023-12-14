using System;

namespace _04_Proprietes
{
    internal class Personne
    {
        // Attributs

        // Propriétés

        // Accesseur = Accéder à la donnée = Getter
        // Mutateur = Modifier la donnée = Setter

        // Full-Properties
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set => _nom = value; // Avec lambda expression
        }

        // Auto-properties
        public string Prenom { get; set; }

        public DateTime DateNaiss { get; set; }

        // Auto-properties en lecture seule
        // Ne retourne que l'age en fonction de la date de naissance fournie
        public int Age => (int)(DateTime.Today - DateNaiss).TotalDays / 365;

        // Opérations (méthodes)
        public void Marcher()
        {
            Console.WriteLine("Je marche...");
        }

        public void DireBonjour()
        {
            Console.WriteLine($"{Nom} {Prenom} dit bonjour");
        }
    }
}