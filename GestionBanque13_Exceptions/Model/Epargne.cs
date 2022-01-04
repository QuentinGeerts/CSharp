using System;

namespace GestionBanque.Model
{

    class Epargne : Compte
    {
        // Attributs
        private DateTime _DateDernierRetrait;

        // Propriétés
        public DateTime DateDernierRetrait
        {
            get { return _DateDernierRetrait; }
            private set { _DateDernierRetrait = value; }
        }

        // Constructeurs
        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        }

        // Méthodes
        public override void Retrait(double Montant)
        {
            double AncienSolde = Solde;
            base.Retrait(Montant);

            if (Solde != AncienSolde) DateDernierRetrait = DateTime.Now;
        }

        protected override double CalculInteret()
        {
            return Solde * 4.5 / 100;
        }
    }
}
