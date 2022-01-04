using System;

namespace _08_Polymorphisme
{
    class Bateau : Vehicule
    {
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.Write(" en bateau");
        }
    }
}
