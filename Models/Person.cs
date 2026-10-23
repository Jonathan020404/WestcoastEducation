namespace WestcoastEducation.Models;

public class Person(string firstName, string lastName, string phoneNumber, string identityNumber)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string PhoneNumber { get; set; } = phoneNumber;
    public string IdentityNumber { get; set; } = identityNumber;
    public string? Address { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }

    public virtual string GetInfo()
    {
        return $"{FirstName} {LastName}, Telefon: {PhoneNumber}, Personnummer: {IdentityNumber}";
    }
}
