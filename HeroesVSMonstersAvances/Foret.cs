using HeroesVSMonsters.Personnages;
using HeroesVSMonsters.Tools;
using System;
using System.Threading;

namespace HeroesVSMonsters
{
    class Foret
    {
        #region Attributes
        private string _Nom;
        private readonly Hero _Hero;
        private Monstre _Monstre;
        private readonly De _DeMonstres;
        private bool _GameOver;
        private int _NbWonFight;
        #endregion

        #region Properties
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        public Hero Hero
        {
            get { return _Hero; }
        }

        public Monstre Monstre
        {
            get { return _Monstre; }
            set { _Monstre = value; }
        }

        public De DeMonstre
        {
            get { return _DeMonstres; }
        }

        private bool GameOver
        {
            get { return _GameOver; }
            set { _GameOver = value; }
        }

        public int NbWonFight
        {
            get { return _NbWonFight; }
            set { _NbWonFight = value; }
        }
        #endregion

        #region Constructor
        public Foret(string nom, Hero hero)
        {
            _DeMonstres = new De(3);
            _Nom = nom;
            _Hero = hero;
            _NbWonFight = 0;
            Hero.Meurt += PersonnageMeurt;
        }
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
                Console.WriteLine($"Le héro a gagné {_NbWonFight} combat(s).");
                Console.WriteLine($"Le héro a accumulé {Hero.Or} pièce(s) d'or.");
                Console.WriteLine($"Le héro a accumulé {Hero.Cuir} cuir(s).");
            }
            else
            {
                Console.WriteLine($"{p.GetType().Name} est mort");
                _NbWonFight++;
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
            bool TourPersonnage = true;

            while (!GameOver)
            {
                if (TourPersonnage)
                {
                    Hero.Frappe(Monstre);
                }
                else
                {
                    Monstre.Frappe(Hero);
                }

                TourPersonnage = !TourPersonnage;
                Thread.Sleep(500);
            }
        }

        private Monstre GenerateRandomMonster()
        {
            Monstre monstre = null;

            switch (DeMonstre.Lance())
            {
                case 1: monstre = new Loup(); break;
                case 2: monstre = new Orque(); break;
                case 3: monstre = new Dragonnet(); break;
            }

            monstre.Meurt += PersonnageMeurt;

            Console.WriteLine();
            Console.WriteLine($"Nous rencontrons un monstre :");
            monstre.Information();

            return monstre;
        }
        #endregion
    }
}
