using System;

namespace _07_HeritageDissimulation
{
    internal class ClasseDerivee : ClasseDeBase
    {
        public override void MethodeRedefinie()
        {
            Console.WriteLine("MethodeRedefinie de la classe dérivée");
        }

        public new void MethodeDissimulee()
        {
            Console.WriteLine("MethodeDissimulee de la classe dérivée");
        }
    }
}