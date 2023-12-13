/*
 * Chapitre : Les Variables
 */

// Une variable en C# est un emplacement de stockage qui a un nom et qui contient une valeur.
// Cette valeur peut changer au cours de l'exécution du programme.
// Chaque variable a un type qui détermine la taille et la disposition de la mémoire de la variable,
// ainsi que l'ensemble des valeurs qu'elle peut stocker et les opérations qui peuvent être effectuées dessus.

/* ----------------------------------------------------------------
 * › Déclaration d'une Variable
 * Réservation d'un emplacement de stockage en mémoire.
 */

int age;

/* ----------------------------------------------------------------
 * › Affectation d'un variable
 * Donner une valeur à une variable
 */

age = 42;

// Possibilité de déclarer et d'initialiser une variable
string prenom = "Quentin";

/* ----------------------------------------------------------------
 * › Types de valeur
 * Ce sont des types de données simples comme int, float, double, bool, char, etc.
 * Ils stockent directement des valeurs. 
 */

// Types entiers
int unEntier = 123;
byte unByte = 255;
short unShort = 32767;
long unLong = 9223372036854775807L;

// Types à virgule flottante
float unFloat = 123.456F;
double unDouble = 123456.789;
decimal unDecimal = 123456.789M;

// Type booléen
bool unBooleen = true;

// Type caractère
char unCaractere = 'A';

// Type struct
DateTime uneDate = DateTime.Now;

/* ----------------------------------------------------------------
 * › Types de référence
 * Ce sont des types qui stockent des références à des emplacements de mémoire.
 * Les exemples incluent des chaînes de caractères (string), des tableaux, ou des objets de classes. 
 */


// Chaîne de caractères
string uneChaine = "Bonjour le monde!"; // constante en mémoire - immuable

// Tableau
int[] unTableau = new int[] { 1, 2, 3, 4, 5 };

// Classe
object unObjet = new Object();