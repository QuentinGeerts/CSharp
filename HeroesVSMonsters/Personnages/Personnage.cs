using System;

using HeroesVSMonsters.Tools;

namespace HeroesVSMonsters.Personnages
{
    class Personnage
    {
        public event Action<Personnage> Meurt;

        // Attributes
        private int _Endurance, _Force, _PV;
        private readonly De _De4, _De6;

        // Properties
        public virtual int Endurance
        {
            get { return _Endurance; }
            private set { _Endurance = value; }
        }

        public virtual int Force
        {
            get { return _Force; }
            private set { _Force = value; }
        }

        public virtual int PV
        {
            get { return _PV; }
            private set 
            { 
                _PV = value; 
                if (_PV <= 0 && Meurt != null)
                {
                    Meurt(this);
                }
            }
        }

        protected De De4
        {
            get { return _De4; }
        }

        protected De De6
        {
            get { return _De6; }
        }

        // Constructor
        public Personnage()
        {
            _De4 = new De(4);
            _De6 = new De(6);

            Force = De.GetNouvelleCaracteristique();
            Endurance = De.GetNouvelleCaracteristique();
            ResetPV();
        }

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

            return ( caracteristique < 5 ) ? -1 : 
                ( caracteristique < 10 ) ? 0 : 
                ( caracteristique < 15 ) ? 1 : 2;
        }

        public void Frappe(Personnage personnage)
        {
            // Calcul des dégâts
            int degats = De4.Lance() + GetModificateur(Force);

            Console.WriteLine($"{this.GetType().Name} frappe {personnage.GetType().Name} et lui inflige {degats} point(s) de dégats.");

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
