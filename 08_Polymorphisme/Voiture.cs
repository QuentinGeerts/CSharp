using System;

namespace _08_Polymorphisme
{
    class Voiture : Vehicule
    {
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.Write(" en voiture");
        }
    }
}
