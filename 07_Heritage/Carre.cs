using System;

namespace _07_Heritage
{
    class Carre : Rectangle
    {
        // New = Dissimulation de la méthode Dessine
        public new void Dessine()
        {
            Console.WriteLine("Dessine le carré");
        }
    }
}
