using System;

namespace WestcoastEducation.Models;

public class Administrator : EducationManager
{
    public Administrator(
        string firstName,
        string lastName,
        string phoneNumber,
        string identityNumber,
        string field,
        DateOnly employmentDate
    )
        : base(firstName, lastName, phoneNumber, identityNumber, field, employmentDate) { }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}";
    }
}
