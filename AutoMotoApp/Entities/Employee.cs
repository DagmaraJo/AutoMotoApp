namespace AutoMotoApp.Entities;

public class Employee : EntityBase
{
    public Employee()  // must be, to create new() non parameter
    {
    }

    public Employee(string name)  // if exist
    {
    }

    public string? FirstName { get; set; }

    public override string ToString()
    {
        return ($" ID: {Id}, Firstname: {FirstName}");
    }
}
