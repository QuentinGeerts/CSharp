using System;

namespace _09_ClassesAbstraites
{
    internal class Femme : Personne
    {
        public void Accoucher()
        {
            Console.WriteLine($"{Nom} {Prenom} accouche.");
        }

        public override void Ecouter()
        {
            Console.WriteLine("J'entends tout");
        }
    }
}