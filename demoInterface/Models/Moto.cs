using demoInterface.Interfaces;

namespace demoInterface.Models;

public class Moto : Vehicule, IRoue
{
    public void Rouler()
    {
        Console.WriteLine($"Je roule en {GetType().Name}");
    }
}