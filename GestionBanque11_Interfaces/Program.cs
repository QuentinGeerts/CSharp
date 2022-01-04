using GestionBanque.Model;
using System;
using System.Collections.Generic;

namespace GestionBanque11_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Title("-- Gestion de banque - C# OO --");

            #region Création des personnes
            Title("Création des personnes");

            Personne Adrian = new Personne();
            Adrian.Nom = "Prevot";
            Adrian.Prenom = "Adrian";
            Adrian.DateNaiss = DateTime.Now;

            Personne Mathieu = new Personne()
            {
                Nom = "Meurée",
                Prenom = "Mathieu",
                DateNaiss = DateTime.Now
            };
            #endregion

            #region Création des comptes courants
            Title("Création des comptes courants");

            Courant AC = new Courant();
            AC.Titulaire = Adrian;
            AC.Numero = "001";
            //AdrianCourant.Solde = 1500; // Ne fonctionne pas => private set
            AC.LigneDeCredit = 100;

            AC.Depot(500);
            AC.Retrait(610);
            AC.Retrait(100);

            Courant AC2 = new Courant()
            {
                Titulaire = Adrian,
                Numero = "003",
                LigneDeCredit = 50
            };

            AC2.Depot(5000);

            Courant MC = new Courant();
            MC.Titulaire = Mathieu;
            MC.Numero = "002";
            MC.LigneDeCredit = 500;

            MC.Depot(1000);
            MC.Retrait(50);
            #endregion

            #region Création des comptes épargnes
            Title("Création des comptes épargnes");

            Epargne AE = new Epargne() { Titulaire = Adrian, Numero = "004" };
            AE.Depot(200);
            AE.Retrait(50);

            Epargne ME = new Epargne() { Titulaire = Mathieu, Numero = "005" };
            ME.Depot(2000);
            ME.Retrait(1200);
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

            b["001"].Depot(30);
            b["002"].Retrait(300);
            #endregion

            #region Calcul des avoirs
            Title("Calcul des avoirs");

            Console.WriteLine("Adrian : " + b.AvoirDesComptes(Adrian));
            Console.WriteLine("Mathieu : " + b.AvoirDesComptes(Mathieu));
            #endregion

            #region Appliquer les intérêts
            Title("Appliquer les intérêts");

            foreach (KeyValuePair<string, Compte> compte in b.Comptes)
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
            banker.Depot(400);
            banker.Retrait(400);

            ICustomer customer = b["002"];
            Console.WriteLine(customer.Solde);
            customer.Depot(400);
            customer.Retrait(400);
            #endregion
        }

        static void Title(string str)
        {
            Console.WriteLine();
            Console.WriteLine($"---- {str} ----");
        }
    }
}
