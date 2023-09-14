using System;

namespace _11_Interfaces
{
    internal class Bateau : IBateau
    {
        public void Naviguer()
        {
            Console.WriteLine($"La {GetType().Name} navigue");
        }

        public void Tourner()
        {
            Console.WriteLine($"La {GetType().Name} tourne");
        }
    }
}