using System;
using System.Collections.Generic;

namespace GestionBanque.Model
{
    class Banque
    {
        // Attributs
        Dictionary<string, Courant> _Comptes = new Dictionary<string, Courant>();

        // Propriétés
        public string Nom { get; set; }

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

    }
}
