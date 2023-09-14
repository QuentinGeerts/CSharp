using System;

namespace _13_Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var maClasse = new MaClasse();
            int[] ints = { 1, 2, 3, 4, 5, 6 };

            try
            {
                // On essaie de réaliser les instructions dans le Try
                // Si une exception est déclenchée, le bloc catch qui attrape l'exception
                // gère l'exception

                //Console.WriteLine(maClasse.Division(5, 0));
                var index = 5;
                if (index < 0 || index > ints.Length - 1) throw new OutOfMyArrayException(index, ints);
                Console.WriteLine(ints[index]);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OutOfMyArrayException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("En dehors de la portée du tableau.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception");
            }
            finally
            {
                Console.WriteLine("Fin du try");
            }

            Console.WriteLine("Fin du programme");
        }
    }
}