﻿using System;

namespace _06_SurchargesOperateurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Création des fruits --");
            Fruit Pomme = new Fruit() { Nom = "Pomme", Poids = 0.2 };
            Fruit Cerise = new Fruit() { Nom = "Cerise", Poids = 0.15 };
            Fruit Ananas = new Fruit() { Nom = "Ananas", Poids = 0.5 };
            Fruit Litchi = new Fruit() { Nom = "Litchi", Poids = 0.15 };
            Fruit Poire = new Fruit() { Nom = "Poire", Poids = 0.3 };

            Console.WriteLine("-- Création des paniers --");
            Panier panier1 = new Panier();
            Panier panier2 = new Panier();

            Console.WriteLine("-- Ajout des fruits dans le panier1 --");
            panier1.AddFruit(Poire);
            panier1.AddFruit(Pomme);
            panier1.AddFruit(Ananas);
            panier1.AddFruit(Ananas);

            Console.WriteLine("-- Ajout des fruits dans le panier2 --");
            panier2.AddFruit(Litchi);
            panier2.AddFruit(Cerise);
            panier2.AddFruit(Cerise);
            panier2.AddFruit(Cerise);

            Console.WriteLine("-- Parcours des paniers --");
            Console.WriteLine();
            Console.WriteLine("Panier 1");
            foreach ( Fruit fruit in panier1.Fruits )
            {
                Console.WriteLine(fruit.Nom);
            }
            Console.WriteLine();
            Console.WriteLine("Panier 2");
            foreach ( Fruit fruit in panier2.Fruits )
            {
                Console.WriteLine(fruit.Nom);
            }

            Console.WriteLine("-- Fusion des deux paniers avec l'opérateur + --");
            Panier panierTotal = panier1 + panier2 + panier2 + panier2;
            Console.WriteLine();
            Console.WriteLine("Panier Total");
            foreach ( Fruit fruit in panierTotal.Fruits )
            {
                Console.WriteLine(fruit.Nom);
            }

            Console.WriteLine("-- Comparer le nombre de fruits de chaque panier --");
            Console.WriteLine("Poids du panier p1 : " + Panier.GetWeight(panier1));
            Console.WriteLine("Poids du panier p2 : " + Panier.GetWeight(panier2));

            if ( panier1 > panier2 )
            {
                Console.WriteLine("Le panier1 est plus lourd que le panier2.");
            }
            else if ( panier1 < panier2 )
            {
                Console.WriteLine("Le panier2 est plus lourd que le panier1.");
            }
            else
            {
                Console.WriteLine("Les deux paniers font le même poids.");
            }
        }
    }
}