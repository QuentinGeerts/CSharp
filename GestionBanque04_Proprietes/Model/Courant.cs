namespace GestionBanque.Model
{
    internal class Courant
    {
        private double _LigneDeCredit;

        // Attributs

        // Propriétés
        public string Numero { get; set; }

        public double Solde { get; private set; }

        public double LigneDeCredit
        {
            get => _LigneDeCredit;
            set
            {
                if (value < 0) return; // À remplacer plus tard par une exception

                _LigneDeCredit = value;
            }
        }

        public Personne Titulaire { get; set; }

        // Méthodes
        public void Retrait(double Montant)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            if (Solde - Montant < -LigneDeCredit) return; // À remplacer plus tard par une exception

            Solde -= Montant;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            Solde += Montant;
        }
    }
}