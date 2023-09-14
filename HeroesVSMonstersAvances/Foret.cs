using System;
using System.Threading;
using HeroesVSMonsters.Personnages;
using HeroesVSMonsters.Tools;

namespace HeroesVSMonsters
{
    internal class Foret
    {
        #region Constructor

        public Foret(string nom, Hero hero)
        {
            DeMonstre = new De(3);
            Nom = nom;
            Hero = hero;
            NbWonFight = 0;
            Hero.Meurt += PersonnageMeurt;
        }

        #endregion

        #region Attributes

        #endregion

        #region Properties

        public string Nom { get; set; }

        public Hero Hero { get; }

        public Monstre Monstre { get; set; }

        public De DeMonstre { get; }

        private bool GameOver { get; set; }

        public int NbWonFight { get; set; }

        #endregion

        #region Methods

        private void PersonnageMeurt(Personnage p)
        {
            p.Meurt -= PersonnageMeurt;

            if (p is Hero)
            {
                GameOver = true;

                Console.WriteLine();
                Console.WriteLine($"{p.GetType().Name} est mort.");
                Console.WriteLine($"Le héro a gagné {NbWonFight} combat(s).");
                Console.WriteLine($"Le héro a accumulé {Hero.Or} pièce(s) d'or.");
                Console.WriteLine($"Le héro a accumulé {Hero.Cuir} cuir(s).");
            }
            else
            {
                Console.WriteLine($"{p.GetType().Name} est mort");
                NbWonFight++;
                Hero.SeReposer();
                Hero.Depouiller((Monstre)p);

                Console.WriteLine("Lancer le prochain combat");
                Console.ReadLine();

                Monstre = GenerateRandomMonster();
            }
        }

        public void Lance()
        {
            Monstre = GenerateRandomMonster();
            var TourPersonnage = true;

            while (!GameOver)
            {
                if (TourPersonnage)
                    Hero.Frappe(Monstre);
                else
                    Monstre.Frappe(Hero);

                TourPersonnage = !TourPersonnage;
                Thread.Sleep(500);
            }
        }

        private Monstre GenerateRandomMonster()
        {
            Monstre monstre = null;

            switch (DeMonstre.Lance())
            {
                case 1:
                    monstre = new Loup();
                    break;
                case 2:
                    monstre = new Orque();
                    break;
                case 3:
                    monstre = new Dragonnet();
                    break;
            }

            monstre.Meurt += PersonnageMeurt;

            Console.WriteLine();
            Console.WriteLine("Nous rencontrons un monstre :");
            monstre.Information();

            return monstre;
        }

        #endregion
    }
}