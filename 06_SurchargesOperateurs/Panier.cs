using System.Collections.Generic;

namespace _06_SurchargesOperateurs
{
    class Panier
    {
        private List<Fruit> _Fruits = new List<Fruit>();

        public List<Fruit> Fruits { get { return _Fruits; } }

        public void AddFruit(Fruit fruit)
        {
            _Fruits.Add(fruit);
        }

        public static double GetWeight(Panier p)
        {
            double Poids = 0;
            foreach (Fruit fruit in p.Fruits)
            {
                Poids += fruit.Poids;
            }

            return Poids;
        }

        // Surcharge d'opérateur +
        public static Panier operator +(Panier p1, Panier p2)
        {
            Panier panier = new Panier();

            foreach (Fruit fruit in p1.Fruits)
            {
                panier.AddFruit(fruit);
            }

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
