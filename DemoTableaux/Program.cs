/*
 * Chapitre sur les Arrays
 */

// Création d'un tableau à une dimesions de 10 entiers

int[] monTableau = new int[10];

// Création à la volée d'un tableau à une dimension de 10 entiers
int[] monTableau2 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Indice = position de la case dans le tableau
monTableau[0] = 5; // Ajoute la valeur 5 à l'emplacement n°0 du tableau 1
monTableau[1] = 1;
monTableau[2] = 6;
monTableau[3] = 2;
monTableau[4] = 3;

Console.WriteLine(monTableau); // Affiche le tableau de type CTE

// Pour afficher les éléments du tableau, nous devons les afficher 1 à 1
// Comment parcourir un tableau rapidement ? En utilisant une boucle !

Console.WriteLine("Avec la boucle while");

int indice = 0;
while (indice < 10)
{
    Console.WriteLine(indice + " : " + monTableau[indice]);
    indice++;
}

// Utilisation de la boucle foreach pour passer sur chaque élément du tableau

Console.WriteLine("Avec la boucle foreach");
int index = 0;
foreach (int value in monTableau)
{
    Console.WriteLine(index + " : " + value);
    index++;
}

// Pour récupérer la taille (le nombre d'éléments) du tableau
Console.WriteLine("Taille du tableau : " + monTableau.Length);