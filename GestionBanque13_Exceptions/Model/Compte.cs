using System;

namespace GestionBanque.Model
{
    abstract class Compte : IBanker
    {
        private string _Numero;
        private double _Solde;
        private Personne _Titulaire;

        // Propriétés
        public string Numero
        {
            get { return _Numero; }
            private set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            private set { _Titulaire = value; }
        }

        // Constructeurs
        public Compte(string numero, Personne titulaire) : this(numero, titulaire, 0)
        {

        }

        public Compte(string numero, Personne titulaire, double solde) 
        {
            Numero = numero;
            Titulaire = titulaire;
            Solde = solde;
            Console.WriteLine($"Compte {this.GetType().Name} créé.");
        }

        // Méthodes
        public virtual void Retrait(double Montant)
        {
            Retrait(Montant, 0.0);
        }

        public void Retrait(double Montant, double LigneDeCredit)
        {
            //if (Montant <= 0) return; // À remplacer plus tard par une exception
            if (Montant <= 0)
                throw new ArgumentOutOfRangeException("Montant", "[Exception] Vous devez entrer un montant positif strictement supérieur à 0.");

            //if (Solde - Montant < -LigneDeCredit) return; // À remplacer plus tard par une exception
            if ( Solde - Montant < -LigneDeCredit )
                throw new SoldeInsuffisantException("[Exception] Solde insuffisant");

            Console.WriteLine($"[Retrait] : Compte n°{Numero} de {Montant}e");
            Solde -= Montant;
        }

        public void Depot(double Montant)
        {
            //if (Montant <= 0) return; // À remplacer plus tard par une exception
            if ( Montant <= 0 ) 
                throw new ArgumentOutOfRangeException("Montant", "[Exception] Vous devez entrer un montant positif strictement supérieur à 0.");

            Console.WriteLine($"[Dépot] : Compte n°{Numero} de {Montant}e");
            Solde += Montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            Console.WriteLine($"[AppliquerInteret] Compte n°{Numero} Solde AVANT : {Solde}e");
            Solde += CalculInteret();
            Console.WriteLine($"[AppliquerInteret] Compte n°{Numero} Solde APRES : {Solde}e");
        }

        // Surcharge d'opérateurs
        public static double operator +(double Solde, Compte Compte)
        {
            return Solde + (Compte.Solde > 0.0 ? Compte.Solde : 0.0);
        }
    }
}
