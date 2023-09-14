using System;

namespace _11_Interfaces
{
    internal class Voiture : IVoiture
    {
        public virtual void Rouler()
        {
            Console.WriteLine($"La {GetType().Name} roule");
        }

        public virtual void Tourner()
        {
            Console.WriteLine($"La {GetType().Name} tourne");
        }
    }
}