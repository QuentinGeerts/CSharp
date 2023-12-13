using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionBanque.Model
{
    class Banque
    {
        // Attributs
        Dictionary<string, Courant> _Comptes = new Dictionary<string, Courant>();

        // Propriétés
        public string Nom { get; set; }

        public KeyValuePair<string, Courant>[] Comptes
        {
            get
            {
                return _Comptes.ToArray();
            }
        }

        // Indexeurs
        public Courant this[string Numero]
        {
            get
            {
                _Comptes.TryGetValue(Numero, out Courant courant);
                return courant;
            }
        }

        // Méthodes
        public void Ajouter(Courant Compte)
        {
            if (_Comptes.TryAdd(Compte.Numero, Compte))
            {
                Console.WriteLine($"Le compte n°{Compte.Numero} a été ajouté.");
            }
            else
            {
                Console.WriteLine("Le compte existe déjà.");
            }
        }

        public void Supprimer(string Numero)
        {
            _Comptes.Remove(Numero);
        }

        public double AvoirDesComptes(Personne p)
        {
            double TotalDesAvoirs = 0.0;

            foreach (Courant c in _Comptes.Values)
            {
                if (c.Titulaire == p)
                {
                    Console.WriteLine($"[AvoirDesComptes] {c.Titulaire.Nom} {c.Titulaire.Prenom} n°{c.Numero} : {c.Solde}e");
                    TotalDesAvoirs += c; // TotalDesAvoirs = TotalDesAvoirs + c // double + Courant
                }
            }

            return TotalDesAvoirs;
        }

    }
}
