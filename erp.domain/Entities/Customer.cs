namespace erp.domain.Entities;

public class Customer : Entity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;

    // Optional: A computed property to get the full name of the customer
    public string FullName => $"{FirstName} {LastName}";

    // Optional: An override of ToString() for better readability
    public override string ToString()
    {
        return $"Customer: {FullName}, Email: {Email}, Phone: {PhoneNumber}";
    }
}
