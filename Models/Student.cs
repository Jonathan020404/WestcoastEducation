namespace WestcoastEducation.Models;

public class Student(string firstName, string lastName, string phoneNumber, string identityNumber)
    : Person(firstName, lastName, phoneNumber, identityNumber)
{
    public override string GetInfo()
    {
        return $"{base.GetInfo()}";
    }
}
