namespace CustomerApi.Models
{
    public class CustomerList : ICustomerList
    {
        public List<Customer> AllCustomers { get; set; } = new List<Customer>() { new Customer { Id = 1, Name = "Pete", Age = 36, Postcode = "BS2 9TX", HeightInMeters = 1.80 } };

        private int MaxId => AllCustomers.Max(x => x.Id);

        public void AddCustomer(Customer customer)
        {
            if (customer.Id == 0)
            {
                customer.Id = MaxId + 1;
            }

            AllCustomers.Add(customer);
        }

        public Customer GetCustomer(int id)
        {
            return AllCustomers.Single(x => x.Id == id);
        }

        public void UpdateCustomer(Customer customer)
        {
            RemoveCustomer(customer.Id);
            AddCustomer(customer);
        }

        private void RemoveCustomer(int id)
        {
            AllCustomers.RemoveAll(x => x.Id == id);
        }
    }
}
