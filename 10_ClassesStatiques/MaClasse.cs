namespace _10_ClassesStatiques
{
    class MaClasse /*: ClasseStatique*/
    {
        public static string Y { get; set; }
        public int X { get; set; } // Propriété d'instance

        public static double Addition(double a, double b)
        {
            return a + b;
        }
    }
}
