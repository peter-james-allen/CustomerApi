namespace CustomerApi.Models
{
    public interface ICustomer
    {
        int Id { get; set; }
        int Age { get; set; }
        double HeightInMeters { get; set; }
        string Name { get; set; }
        string Postcode { get; set; }
    }
}