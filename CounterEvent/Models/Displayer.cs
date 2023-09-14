namespace CounterEvent.Models;

public class Displayer
{
    public void DisplayNewValue(int newValue)
    {
        Console.WriteLine($"Nouvelle valeur du compteur : {newValue}");
    }
}