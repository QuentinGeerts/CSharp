using System.Collections.Generic;

namespace _06_SurchargesOperateurs.Models
{
    class Panier
    {
        private readonly List<Fruit> _fruits = new List<Fruit>();

        public List<Fruit> Fruits => _fruits;

        public void AddFruit(Fruit fruit)
        {
            if (fruit is null) return;
            _fruits.Add(fruit);
        }

        public static double GetWeight(Panier p)
        {
            double poids = 0;

            foreach (Fruit fruit in p.Fruits)
            {
                poids += fruit.Poids;
            }

            return poids;
        }

        // Surcharge d'opérateur +
        // Permet de retourner un nouveau panier contenant les fruits 
        // des deux paniers additionnés
        public static Panier operator +(Panier p1, Panier p2)
        {
            Panier panier = new Panier();

            // Ajouter le premier panier dans le grand
            foreach (Fruit fruit in p1.Fruits)
            {
                panier.AddFruit(fruit);
            }

            // Ajouter le deuxième panier dans le grand
            foreach (Fruit fruit in p2.Fruits)
            {
                panier.AddFruit(fruit);
            }

            return panier;
        }

        public static bool operator ==(Panier p1, Panier p2)
        {
            return GetWeight(p1) == GetWeight(p2);
        }

        public static bool operator !=(Panier p1, Panier p2)
        {
            return !(p1 == p2);
        }

        public static bool operator <(Panier p1, Panier p2)
        {
            return GetWeight(p1) < GetWeight(p2);
        }

        public static bool operator >(Panier p1, Panier p2)
        {
            return GetWeight(p1) > GetWeight(p2);
        }

        public static bool operator <=(Panier p1, Panier p2)
        {
            return GetWeight(p1) <= GetWeight(p2);
        }

        public static bool operator >=(Panier p1, Panier p2)
        {
            return GetWeight(p1) >= GetWeight(p2);
        }
    }
}