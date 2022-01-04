using System;

namespace _07_Heritage
{
    // Classe enfant, dérivée, sous classe
    // sealed = Empecher l'héritage à nouveau
    /*sealed*/
    class Rectangle : Forme
    {
        private double _Largeur;
        private double _Longueur;

        public double Largeur
        {
            get { return _Largeur; }
            set { _Largeur = value; }
        }

        public double Longueur
        {
            get { return _Longueur; }
            set { _Longueur = value; }
        }

        private int _X { get; set; }

        // override = redéfinition de la méthode Dessine
        public override void Dessine()
        {
            base.Dessine();
            Console.WriteLine("qui est un rectangle");
        }

    }
}
