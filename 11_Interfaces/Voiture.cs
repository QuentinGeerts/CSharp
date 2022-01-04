using System;

namespace _11_Interfaces
{
    class Voiture : IVoiture
    {
        public virtual void Rouler()
        {
            Console.WriteLine($"La {this.GetType().Name} roule");
        }

        public virtual void Tourner()
        {
            Console.WriteLine($"La {this.GetType().Name} tourne");
        }
    }
}
