namespace CustomerApi.Models
{
    public interface ICustomerList
    {
        List<Customer> AllCustomers { get; set; }
        void AddCustomer(Customer customer);
        Customer GetCustomer(int id);
        void UpdateCustomer(Customer customer);
    }
}