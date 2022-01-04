using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionBanque.Model
{
    class Banque
    {
        // Attributs
        Dictionary<string, Compte> _Comptes = new Dictionary<string, Compte>();

        // Propriétés
        public string Nom { get; set; }

        public KeyValuePair<string, Compte>[] Comptes
        {
            get
            {
                return _Comptes.ToArray();
            }
        }

        // Indexeurs
        public Compte this[string Numero]
        {
            get
            {
                _Comptes.TryGetValue(Numero, out Compte courant);
                return courant;
            }
        }

        // Méthodes
        public void Ajouter(Compte Compte)
        {
            if (_Comptes.TryAdd(Compte.Numero, Compte))
            {
                Console.WriteLine($"Le compte {Compte.GetType().Name} n°{Compte.Numero} a été ajouté.");
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

        public double AvoirDesComptes (Personne p)
        {
            double TotalDesAvoirs = 0.0;

            foreach (Compte c in _Comptes.Values)
            {
                if (c.Titulaire == p)
                {
                    Console.WriteLine($"[AvoirDesComptes] {c.GetType().Name} {c.Titulaire.Nom} {c.Titulaire.Prenom} n°{c.Numero} : {c.Solde}e");
                    TotalDesAvoirs += c; // TotalDesAvoirs = TotalDesAvoirs + c // double + Courant
                }
            }

            return TotalDesAvoirs;
        }

    }
}
