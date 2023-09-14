namespace CounterEvent.Models;

public class Counter
{
    // Déclaration d'un délégué pour l'événement
    public delegate void ChangedValueEventHandler(int newValue);

    private int _value;

    // Événement déclenché lorsque la valeur change
    public event ChangedValueEventHandler ChangedValue;

    public void Increase()
    {
        _value++;

        // Vérifie si quelqu'un est abonné à l'événement
        if (ChangedValue != null)
            // Déclenche l'événement en passant la nouvelle valeur
            ChangedValue(_value);
    }
}