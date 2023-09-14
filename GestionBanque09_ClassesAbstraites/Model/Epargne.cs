using System;

namespace GestionBanque.Model
{
    internal class Epargne : Compte
    {
        // Attributs

        // Propriétés
        public DateTime DateDernierRetrait { get; private set; }

        // Méthodes
        public override void Retrait(double Montant)
        {
            var AncienSolde = Solde;
            base.Retrait(Montant);

            if (Solde != AncienSolde) DateDernierRetrait = DateTime.Now;
        }

        protected override double CalculInteret()
        {
            return Solde * 4.5 / 100;
        }
    }
}