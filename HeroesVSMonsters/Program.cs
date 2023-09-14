using System;
using HeroesVSMonsters.Personnages;

namespace HeroesVSMonsters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("~~ Création du Hero ~~");

            Console.WriteLine("Sélection de la classe :\n1 = Humain\n2 = Nain\n\nChoix :");
            int choix;

            while (!int.TryParse(Console.ReadLine(), out choix) || !(choix == 1 || choix == 2))
                Console.WriteLine("Mauvais choix.\n1 = Humain\n2 = Nain\n\nChoix :");

            Hero hero = choix == 1 ? new Humain() : new Nain();

            hero.Information();

            Console.WriteLine("~~ Création de la foret ~~");
            var shorewood = new Foret("Shorewood", hero);

            Console.WriteLine("~~ Début de la partie ~~");
            shorewood.Lance();
        }
    }
}