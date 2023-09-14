using System;
using HeroesVSMonsters.Tools;

namespace HeroesVSMonsters.Personnages
{
    internal class Personnage
    {
        // Attributes
        private int _PV;

        // Constructor
        public Personnage()
        {
            De4 = new De(4);
            De6 = new De(6);

            Force = De.GetNouvelleCaracteristique();
            Endurance = De.GetNouvelleCaracteristique();
            ResetPV();
        }

        // Properties
        public virtual int Endurance { get; }

        public virtual int Force { get; }

        public virtual int PV
        {
            get => _PV;
            private set
            {
                _PV = value;
                if (_PV <= 0 && Meurt != null) Meurt(this);
            }
        }

        protected De De4 { get; }

        protected De De6 { get; }

        public event Action<Personnage> Meurt;

        // Methods
        public void ResetPV()
        {
            PV = Endurance + GetModificateur(Endurance);
        }

        private int GetModificateur(int caracteristique)
        {
            //if ( endurance < 5 ) return -1;
            //else if ( endurance < 10 ) return 0;
            //else if ( endurance < 15 ) return 1;
            //else return 2;

            return caracteristique < 5 ? -1 :
                caracteristique < 10 ? 0 :
                caracteristique < 15 ? 1 : 2;
        }

        public void Frappe(Personnage personnage)
        {
            // Calcul des dégâts
            var degats = De4.Lance() + GetModificateur(Force);

            Console.WriteLine(
                $"{GetType().Name} frappe {personnage.GetType().Name} et lui inflige {degats} point(s) de dégats.");

            personnage.PV -= degats;
        }

        public void Information()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"PV        : {PV}");
            Console.WriteLine($"Force     : {Force}");
            Console.WriteLine($"Endurance : {Endurance}");
        }
    }
}