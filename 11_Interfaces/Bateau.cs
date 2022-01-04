using System;

namespace _11_Interfaces
{
    class Bateau : IBateau
    {
        public void Naviguer()
        {
            Console.WriteLine($"La {this.GetType().Name} navigue");
        }

        public void Tourner()
        {
            Console.WriteLine($"La {this.GetType().Name} tourne");
        }
    }
}
