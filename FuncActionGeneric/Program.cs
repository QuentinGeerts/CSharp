// Exemple avec Func : addition de deux nombres et renvoi du résultat.
static int Add(int x, int y)
{
    return x + y;
}

// Exemple avec Action : affichage d'un message à la console.
static void PrintMessage(string message)
{
    Console.WriteLine(message);
}

static void Main()
{
    // Utilisation de Func pour effectuer une addition.
    Func<int, int, int> addFunc = Add;
    int sum = addFunc(5, 3);
    Console.WriteLine("Résultat de l'addition : " + sum); // Affiche "Résultat de l'addition : 8"

    // Utilisation de Action pour afficher un message.
    Action<string> printAction = PrintMessage;
    printAction("Bonjour, C# !"); // Affiche "Bonjour, C# !"
}