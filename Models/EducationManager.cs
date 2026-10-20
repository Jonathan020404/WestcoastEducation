using System;

namespace WestcoastEducation.Models;

public class EducationManager : Teacher
{
    public DateOnly EmploymentDate { get; set; }

    public EducationManager(
        string firstName,
        string lastName,
        string phoneNumber,
        string identityNumber,
        string field,
        DateOnly employmentDate
    )
        : base(firstName, lastName, phoneNumber, identityNumber, field)
    {
        EmploymentDate = employmentDate;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Anställningsdatum: {EmploymentDate}";
    }
}
