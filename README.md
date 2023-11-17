# CustomerApi

This API is based on the brief outlined [here](./Application Programming Test.pdf). The solution is a ASP.NET Core RESTful API using the MVC pattern with Razor views to display the frontend.

## Frontend Technology
I am not too familiar with frontend so decided to use Razor views as they can be easily scaffolded using Visual Studio and integrated into the ASP.NET Core template. I chose it because it was quick to set up and was good to learn something new.

## Design Decisions
I chose to use a REST API as it is quick to set up, easy to understand as it implements a standard format and stateless so all requests are independent.

I chose to use the MVC pattern as it promotes the separation of concerns, giving each part a responsibility. Making the system easier to expand on or update - parts can be switched out, and easier to test as each part can be tested in isolation.

Validation checks of the inputs are done on the client side for speed – doesn’t need to contact server, saving computing and bandwidth.

I chose to use a Singleton to represent the data (list of customers),as it gives a single source of truth for the data in the application and ensures it cannot be modified by two threads at once. I abstracted it to an interface (ICustomerList) so I could use Dependency Injection to add it to the controllers which means it can mocked in unit tests.

Using the interface means that the code can easily be reused and in the future a database could be connected.

NOTE: the CustomerList class creates a new Customer, this is only to display some data on startup. I would not new up a class inside another in any final code as it is bad practise and creates a dependancy and makes the code harder to test. I would use the factory pattern instead.

## Issues Found
I could not implement the requirement to disable the submit button on the user form unless the validation checks for the fields had passed. I could disable the button by checking the ViewData.ModelState.IsValid property, but did not know how to refresh the check when fields had been updated and did not have time to find a solution.

## Next Steps
There are a number of things that could be done to make this better.

- Writing complete unit tests using NUnit for the CustomerList (I started this but did not have time) and integration tests for the CustomerController using WebApplicationFactory to create a test program and call the different endpoints and check that the CustomerList methods were being called by injecting a mock CustomerList object into the services.

- Write frontend tests using a framework such as playwright that would test the UI is working correctly.

- Create a SQL database and then create a migration file using the Customer class so that I could map the customer data to a SQL table using Entity Framework. This would enable me to set up a DBContext in the code and replace the CustomerList as the source of the data.

- Add a DELETE endpoint (Customer/Delete/{id}) to complete the CRUD operations for the customer data. I would create a new endpoint that would take the POST HTTP method with an ID of the record to be deleted.

- Tidy up the UI and use bootstrap to make the views look nicer, with thought given to UX.
