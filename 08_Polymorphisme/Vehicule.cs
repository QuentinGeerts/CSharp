using System;

namespace _08_Polymorphisme
{
    internal class Vehicule
    {
        public virtual void SeDeplacer()
        {
            Console.Write("Je me déplace ...");
        }
    }
}