using demoInterface.Interfaces;

namespace demoInterface.Models;

public class Voiture : Vehicule, IRoue
{
    public void Rouler()
    {
        Console.WriteLine($"Je roule en {GetType().Name}");
    }
}