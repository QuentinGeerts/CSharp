using System;

namespace _13_Exceptions
{
    // Création de votre propre exception
    internal class OutOfMyArrayException : Exception
    {
        public OutOfMyArrayException(int index, int[] array) : this(index, array,
            $"L'index {index} n'est pas compris dans les bornes du tableau : [0 - {array.Length - 1}]")
        {
        }

        public OutOfMyArrayException(int index, int[] array, string message) : base(message)
        {
            Index = index;
            Array = array;
        }

        public int Index { get; set; }
        public int[] Array { get; set; }
    }
}