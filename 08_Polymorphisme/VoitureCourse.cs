using System;

namespace _08_Polymorphisme
{
    internal class VoitureCourse : Voiture
    {
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.Write(" de course");
        }
    }
}