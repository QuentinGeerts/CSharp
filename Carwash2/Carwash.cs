using System;

namespace Carwash2
{
    internal class Carwash
    {
        private readonly CarwashDelegate cd;

        public Carwash()
        {
            // Méthode anonyme
            cd += delegate(Voiture v) { Console.WriteLine($"Je prépare la voiture : {v.Plaque}"); };

            cd += delegate(Voiture v) { Console.WriteLine($"Je lave la voiture : {v.Plaque}"); };

            // Instruction Lambda
            cd += v => Console.WriteLine($"Je sèche la voiture : {v.Plaque}");

            cd += v => { Console.WriteLine($"Je finalise la voiture : {v.Plaque}"); };
        }

        public void Traiter(Voiture v)
        {
            if (cd != null) cd(v);
            Console.WriteLine();
        }
    }
}