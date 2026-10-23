namespace WestcoastEducation.Models;

public class Administrator(
    string firstName,
    string lastName,
    string phoneNumber,
    string identityNumber,
    string field,
    DateOnly employmentDate
) : EducationManager(firstName, lastName, phoneNumber, identityNumber, field, employmentDate)
{
    public override string GetInfo()
    {
        return $"{base.GetInfo()}";
    }
}
