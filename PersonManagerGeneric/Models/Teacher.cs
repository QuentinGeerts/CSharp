namespace PersonManagerGeneric.Models;

public class Teacher : Person
{
    public Teacher(string name, int age, string employeeID) : base(name, age)
    {
        EmployeeID = employeeID;
    }

    public string EmployeeID { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Identifiant Employé : {EmployeeID}";
    }
}