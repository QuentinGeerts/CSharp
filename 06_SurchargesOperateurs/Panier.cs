using System.Collections.Generic;

namespace _06_SurchargesOperateurs
{
    internal class Panier
    {
        public List<Fruit> Fruits { get; } = new();

        public void AddFruit(Fruit fruit)
        {
            Fruits.Add(fruit);
        }

        public static double GetWeight(Panier p)
        {
            double Poids = 0;
            foreach (var fruit in p.Fruits) Poids += fruit.Poids;

            return Poids;
        }

        // Surcharge d'opérateur +
        public static Panier operator +(Panier p1, Panier p2)
        {
            var panier = new Panier();

            foreach (var fruit in p1.Fruits) panier.AddFruit(fruit);

            foreach (var fruit in p2.Fruits) panier.AddFruit(fruit);

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