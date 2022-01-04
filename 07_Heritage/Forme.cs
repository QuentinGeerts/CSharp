using System;

namespace _07_Heritage
{
    // Classe parent qui hérite de ses membres aux classes dérivées
    class Forme
    {
        protected string _Couleur;

        public string Couleur
        {
            get { return _Couleur; }
            set { _Couleur = value; }
        }

        // Virtual : Permet la redéfinition de la méthode dans les types dérivés
        public virtual void Dessine()
        {
            Console.WriteLine("Dessine la forme.");
        }
    }
}
