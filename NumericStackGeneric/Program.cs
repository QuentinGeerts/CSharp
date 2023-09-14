// Créer une pile numérique pour les entiers

using NumericStackGeneric.Models;

NumericStack<int> intStack = new NumericStack<int>();

// Ajouter des entiers à la pile
intStack.Push(1);
intStack.Push(2);
intStack.Push(3);

// Retirer des entiers de la pile
int poppedInt1 = intStack.Pop();
int poppedInt2 = intStack.Pop();

Console.WriteLine("Entier retiré 1 : " + poppedInt1);
Console.WriteLine("Entier retiré 2 : " + poppedInt2);

// Créer une pile numérique pour les nombres à virgule flottante
NumericStack<double> doubleStack = new NumericStack<double>();

// Ajouter des nombres à virgule flottante à la pile
doubleStack.Push(1.1);
doubleStack.Push(2.2);
doubleStack.Push(3.3);

// Retirer des nombres à virgule flottante de la pile
double poppedDouble1 = doubleStack.Pop();
double poppedDouble2 = doubleStack.Pop();

Console.WriteLine("Nombre à virgule flottante retiré 1 : " + poppedDouble1);
Console.WriteLine("Nombre à virgule flottante retiré 2 : " + poppedDouble2);