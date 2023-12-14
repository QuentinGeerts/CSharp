using System;

namespace _09_ClassesAbstraites
{
    internal class Homme : Personne
    {
        // Redéfinition de la méthode Ecouter (abstract) du parent
        public override void Ecouter()
        {
            Console.WriteLine("Je n'écoute rien");
        }

        public void SeRaser()
        {
            Console.WriteLine($"{Nom} {Prenom} se rase la barbe.");
        }
    }
}