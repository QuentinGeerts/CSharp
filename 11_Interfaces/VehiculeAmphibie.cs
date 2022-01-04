using System;

namespace _11_Interfaces
{
    class VehiculeAmphibie : Voiture, IBateau
    {
        public void Naviguer()
        {
            Console.WriteLine($"Le {this.GetType().Name} navigue");
        }

        public override void Rouler()
        {
            Console.WriteLine($"Le VehiculeAmphibie roule");
        }

        public override void Tourner()
        {
            Console.WriteLine($"Le VehiculeAmphibie tourne");
        }
    }
}
