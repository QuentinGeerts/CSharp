using System;

namespace _02_Encapsulation
{
    // Encapsulation : 
    // de la classe (par défaut) : internal
    // dans la classe (par défaut) : private
    internal class Personne
    {
        public DateTime dateNaiss;

        // Attributs
        public string nom;
        public string prenom;

        // Opérations (méthodes)
        public void Marcher()
        {
            Console.WriteLine("Je marche...");
        }

        public void DireBonjour()
        {
            Console.WriteLine($"{nom} {prenom} dit bonjour");
        }
    }
}