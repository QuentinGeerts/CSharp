using System;

namespace GestionBanque.Model
{

    class Epargne
    {
        // Attributs
        private string _Numero;
        private double _Solde;
        private DateTime _DateDernierRetrait;
        private Personne _Titulaire;

        // Propriétés
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }

        public DateTime DateDernierRetrait
        {
            get { return _DateDernierRetrait; }
            private set { _DateDernierRetrait = value; }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            set { _Titulaire = value; }
        }

        // Méthodes
        public void Retrait(double Montant)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            if (Solde - Montant < 0) return; // À remplacer plus tard par une exception

            Console.WriteLine($"[Retrait] : Compte n°{Numero} de {Montant}e");
            
            Solde -= Montant;
            DateDernierRetrait = DateTime.Now;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            Console.WriteLine($"[Dépot] : Compte n°{Numero} de {Montant}e");
            Solde += Montant;
        }
    }
}
