using System;

namespace GestionBanque.Model
{
    internal class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException() : this("[Exception] Solde insuffisant")
        {
        }

        public SoldeInsuffisantException(string message) : base(message)
        {
        }
    }
}