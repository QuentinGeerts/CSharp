using System;

namespace _12_ConstructeursDestructeurs
{
    internal class Personne
    {
        // Constructeur par défaut = constructeur vide
        public Personne()
        {
            Console.WriteLine("Personne a été créée");
        }

        // Surcharge de constructeur
        // : this() => fait appel au constructeur vide repris en première position
        public Personne(string nom, string prenom) : this()
        {
            Nom = nom;
            Prenom = prenom;
        }

        // Surcharge de constructeur
        // : this(nom, prenom) => fait appel au constructeur avec deux paramètres repris en deuxième position
        public Personne(string nom, string prenom, DateTime dateNaiss, double taille, double poids) : this(nom, prenom)
        {
            //Nom = nom;
            //Prenom = prenom;
            DateNaiss = dateNaiss;
            Taille = taille;
            Poids = poids;
        }
        // Pour créer un objet, on a besoin d'un constructeur
        // Constructeur = nomdelaclasse() {}

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }
        public double Taille { get; set; }
        public double Poids { get; set; }

        // Destructeur
        ~Personne()
        {
            Console.WriteLine("Objet personne détruit");
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} {DateNaiss} {Taille} {Poids}";
        }
    }
}