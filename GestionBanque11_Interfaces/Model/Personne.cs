using System;

namespace GestionBanque.Model
{
    internal class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }

        public override string ToString()
        {
            return $"{Nom} {Prenom} né le {DateNaiss}";
        }
    }
}