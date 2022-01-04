using System;

namespace _04_Proprietes
{
    internal class Personne
    {
        // Attributs
        private string _Nom;

        // Propriétés

        // Accesseur = Accéder à la donnée = Getter
        // Mutateur = Modifier la donnée = Setter

        // Full-Properties
        public string Nom
        {
            get
            {
                return _Nom;
            }
            set
            {
                _Nom = value;
            }
        }

        // Auto-properties
        public string Prenom { get; set; }

        public DateTime DateNaiss { get; set; }

        // Auto-properties en lecture seule
        public int Age
        {
            get
            {
                return (int)(DateTime.Today - DateNaiss).TotalDays / 365;
            }
        }

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