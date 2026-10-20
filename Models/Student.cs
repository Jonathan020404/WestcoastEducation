using System;

namespace WestcoastEducation.Models;

public class Student : Person
{
    public Student(string firstName, string lastName, string phoneNumber, string identityNumber)
        : base(firstName, lastName, phoneNumber, identityNumber) { }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}";
    }
}
