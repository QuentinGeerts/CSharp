using System;

namespace _08_Polymorphisme
{
    class VoitureCourse : Voiture
    {
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.Write(" de course");
        }
    }
}
