using System;

namespace WestcoastEducation.Models;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string IdentityNumber { get; set; }
    public string? Address { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }

    public Person(string firstName, string lastName, string phoneNumber, string identityNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        IdentityNumber = identityNumber;
    }

    public virtual string GetInfo()
    {
        return $"{FirstName} {LastName}, Telefon: {PhoneNumber}, Personnummer: {IdentityNumber}";
    }
}
