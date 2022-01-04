using System;

namespace _12_ConstructeursDestructeurs
{
    class Eleve : Personne
    {
        public string Matricule { get; set; }


        public Eleve()
        {
            Console.WriteLine("Eleve a été créé");
        }

        public Eleve(string matricule, string nom, string prenom) : base(nom, prenom)
        {
            Matricule = matricule;
        }

        public Eleve(string matricule, string nom, string prenom, DateTime dateNaiss, double taille, double poids) : base(nom, prenom, dateNaiss, taille, poids)
        {
            //Nom = nom;
            //Prenom = prenom;
            //DateNaiss = dateNaiss;
            //Taille = taille;
            //Poids = poids;
            Matricule = matricule;
        }

        // Destructeur
        ~Eleve()
        {
            Console.WriteLine("Objet élève détruit");
        }
    }
}
