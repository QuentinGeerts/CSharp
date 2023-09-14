using System;

namespace _08_Polymorphisme
{
    internal class Voiture : Vehicule
    {
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.Write(" en voiture");
        }
    }
}