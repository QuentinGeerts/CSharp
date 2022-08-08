using System;

using T = Toto;
using T2 = Toto2;

namespace _01_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            T.MaClasse maClass = new T.MaClasse();
            maClass.Hello();

            T.MaStruct maStruct = new T.MaStruct();
            maStruct.Hello();

            // -----

            T2.MaClasse maClasse = new T2.MaClasse();
        }
    }
}

namespace Toto
{
    class MaClasse
    {
        public void Hello()
        {
            Console.WriteLine("Hello de Toto - MaClasse");
        }
    }

    struct MaStruct
    {
        public void Hello()
        {
            Console.WriteLine("Hello world");
        }

    }
}

namespace Toto2
{
    class MaClasse
    {
        public void Hello()
        {
            Console.WriteLine("Bonjour tout le monde !");
        }
    }
}

namespace Toto2
{
    class MaClasse2
    {
        public void Hello()
        {
            Console.WriteLine("Hello de Toto2 - MaClasse2");
        }
    }
}