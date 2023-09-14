namespace GestionBanque.Model
{
    internal interface IBanker : ICustomer
    {
        Personne Titulaire { get; }
        string Numero { get; }

        void AppliquerInteret();
    }
}