using System;

namespace _11_Interfaces
{
    internal class VehiculeAmphibie : Voiture, IBateau
    {
        public void Naviguer()
        {
            Console.WriteLine($"Le {GetType().Name} navigue");
        }

        public override void Tourner()
        {
            Console.WriteLine("Le VehiculeAmphibie tourne");
        }

        public override void Rouler()
        {
            Console.WriteLine("Le VehiculeAmphibie roule");
        }
    }
}