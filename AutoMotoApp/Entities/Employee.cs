namespace AutoMotoApp.Entities;

public class Employee : EntityBase
{
    public string? FirstName { get; set; }

    public override string ToString()
    {
        return ($" ID: {Id}, Firstname: {FirstName}");
    }
}
