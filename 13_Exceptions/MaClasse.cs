using System;

namespace _13_Exceptions
{
    class MaClasse
    {
        public double Division(int n1, int n2)
        {
            // Throw = Déclenche manuellement l'exception qui sera récupérée dans le bloc try/catch
            if ( n2 == 0 ) throw new DivideByZeroException($"Tu as essayé de diviser {n1} par 0");
            return n1 / n2;
        }
    }
}
