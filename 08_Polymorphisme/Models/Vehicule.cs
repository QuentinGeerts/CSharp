using System;

namespace _08_Polymorphisme.Models
{
    internal class Vehicule
    {
        public virtual void SeDeplacer()
        {
            Console.Write("Je me déplace ...");
        }
    }
}