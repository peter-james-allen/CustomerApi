using NUnit.Framework;
using CustomerApi.Models;

namespace CustomerApi.Test
{
    public class CustomerListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CustomerList_WhenCreated_AlreadyHasOneEntry()
        {
            // Arrange
            var customerList = new CustomerList();

            // Act
            var numberOfCustomers = customerList.AllCustomers.Count;

            // Assert
            Assert.That(numberOfCustomers, Is.EqualTo(1));
        }
    }
}