using System;

namespace _07_HeritageDissimulation
{
    class ClasseDeBase
    {
        public virtual void MethodeRedefinie()
        {
            Console.WriteLine("MethodeRedefinie de la classe de base.");
        }

        public void MethodeDissimulee()
        {
            Console.WriteLine("MethodeDissimulee de la classe de base.");
        }
    }
}
