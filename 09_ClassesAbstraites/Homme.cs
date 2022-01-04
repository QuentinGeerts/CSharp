using System;

namespace _09_ClassesAbstraites
{
    class Homme : Personne
    {
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
