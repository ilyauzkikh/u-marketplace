using Products.Domain.BaseEntities;

namespace Products.Domain.Customers;

public class Customer : Entity
{
    protected Customer() { }

    public Customer(string firstName,
        string lastName,
        string phoneNumber,
        string email)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }
}
