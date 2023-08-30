using Products.Domain.Entities;

namespace Products.Domain.CustomerAggregate;

public class Customer : TrackableEntity
{
    protected Customer() { }

    public Customer(string firstName,
        string lastName,
        string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;    
        PhoneNumber = phoneNumber;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string PhoneNumber { get; private set; }
}
