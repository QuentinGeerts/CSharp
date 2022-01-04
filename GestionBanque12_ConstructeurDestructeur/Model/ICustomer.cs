namespace GestionBanque.Model
{
    public interface ICustomer
    {
        double Solde { get; }
        
        void Depot(double Montant);
        void Retrait(double Montant);
    }
}
