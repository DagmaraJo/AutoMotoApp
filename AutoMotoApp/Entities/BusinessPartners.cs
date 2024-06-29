namespace AutoMotoApp.Entities;

public class BusinessPartner : EntityBase
{
    public string? Name { get; set; }

    public override string ToString()
    {
        return ($" ID: {Id}, Name: {Name}");
    }
}
