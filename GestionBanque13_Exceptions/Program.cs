using System;
using System.Collections.Generic;

using GestionBanque.Model;

namespace GestionBanque13_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Title("-- Gestion de banque - C# OO --");

            #region Création des personnes
            Title("Création des personnes");

            Personne Adrian = new Personne("Prevot", "Adrian", DateTime.Now);
            Personne Mathieu = new Personne("Meurée", "Mathieu", DateTime.Now);
            #endregion

            #region Création des comptes courants
            Title("Création des comptes courants");

            Courant AC = new Courant("001", Adrian);
            //AdrianCourant.Solde = 1500; // Ne fonctionne pas => private set
            try
            {
                AC.LigneDeCredit = 0;

                AC.Depot(500);
                AC.Retrait(610);
                AC.Retrait(100);
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
            }


            Courant AC2 = new Courant("003", Adrian)
            {
                LigneDeCredit = 50
            };
            try
            {
                AC2.Depot(-5000);
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
            }

            Courant MC = new Courant("002", Mathieu);
            try
            {
                MC.LigneDeCredit = 500;

                MC.Depot(1000);
                MC.Retrait(50);
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region Création des comptes épargnes
            Title("Création des comptes épargnes");

            Epargne AE = new Epargne("004", Adrian);

            try
            {
                AE.Depot(200);
                AE.Retrait(50);
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
            }

            Epargne ME = new Epargne("005", Mathieu);
            try
            {
                ME.Depot(2000);
                ME.Retrait(1200);
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region Création de la banque
            Title("Création de la banque");

            Banque b = new Banque();
            b.Nom = "Ma Banque";

            b.Ajouter(AC);
            b.Ajouter(AC2);
            b.Ajouter(AE);
            b.Ajouter(MC);
            b.Ajouter(ME);

            try
            {
                b["001"].Depot(30);
                b["002"].Retrait(300);
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region Calcul des avoirs
            Title("Calcul des avoirs");

            Console.WriteLine("Adrian : " + b.AvoirDesComptes(Adrian));
            Console.WriteLine("Mathieu : " + b.AvoirDesComptes(Mathieu));
            #endregion

            #region Appliquer les intérêts
            Title("Appliquer les intérêts");

            foreach ( KeyValuePair<string, Compte> compte in b.Comptes )
            {
                compte.Value.AppliquerInteret();
                Console.WriteLine();
            }
            #endregion

            #region Utilisation des Interfaces IBanker et ICustomer
            Title("Utilisation des Interfaces IBanker et ICustomer");

            IBanker banker = b["001"];
            Console.WriteLine(banker.Solde);
            Console.WriteLine(banker.Titulaire);
            banker.AppliquerInteret();
            try
            {
                banker.Depot(400);
                banker.Retrait(400);
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
            }

            ICustomer customer = b["002"];
            Console.WriteLine(customer.Solde);
            try
            {
                customer.Depot(400);
                customer.Retrait(400);
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }

        static void Title(string str)
        {
            Console.WriteLine();
            Console.WriteLine($"---- {str} ----");
        }
    }
}
