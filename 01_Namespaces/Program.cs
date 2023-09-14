using System;
using T = Toto;
using T2 = Toto2;

namespace _01_Namespaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var maClass = new T.MaClasse();
            maClass.Hello();

            var maStruct = new T.MaStruct();
            maStruct.Hello();

            // -----

            var maClasse = new T2.MaClasse();
        }
    }
}

namespace Toto
{
    internal class MaClasse
    {
        public void Hello()
        {
            Console.WriteLine("Hello de Toto - MaClasse");
        }
    }

    internal struct MaStruct
    {
        public void Hello()
        {
            Console.WriteLine("Hello world");
        }
    }
}

namespace Toto2
{
    internal class MaClasse
    {
        public void Hello()
        {
            Console.WriteLine("Bonjour tout le monde !");
        }
    }
}

namespace Toto2
{
    internal class MaClasse2
    {
        public void Hello()
        {
            Console.WriteLine("Hello de Toto2 - MaClasse2");
        }
    }
}