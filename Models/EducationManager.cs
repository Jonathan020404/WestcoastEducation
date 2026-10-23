namespace WestcoastEducation.Models;

public class EducationManager(
    string firstName,
    string lastName,
    string phoneNumber,
    string identityNumber,
    string field,
    DateOnly employmentDate
) : Teacher(firstName, lastName, phoneNumber, identityNumber, field)
{
    public DateOnly EmploymentDate { get; set; } = employmentDate;

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Anställningsdatum: {EmploymentDate}";
    }
}
