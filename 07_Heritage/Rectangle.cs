using System;

namespace _07_Heritage
{
    // Classe enfant, dérivée, sous classe
    // sealed = Empecher l'héritage à nouveau
    /*sealed*/
    internal class Rectangle : Forme
    {
        public double Largeur { get; set; }

        public double Longueur { get; set; }

        private int _X { get; set; }

        // override = redéfinition de la méthode Dessine
        public override void Dessine()
        {
            base.Dessine();
            Console.WriteLine("qui est un rectangle");
        }
    }
}