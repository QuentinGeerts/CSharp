using System;

namespace _08_Polymorphisme.Models
{
    internal class Bateau : Vehicule
    {
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.Write(" en bateau");
        }
    }
}