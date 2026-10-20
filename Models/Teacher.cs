using System;

namespace WestcoastEducation.Models;

public class Teacher : Person
{
    public string Field { get; set; }

    public List<Course> Courses { get; set; } = new();

    public Teacher(
        string firstName,
        string lastName,
        string phoneNumber,
        string identityNumber,
        string field
    )
        : base(firstName, lastName, phoneNumber, identityNumber)
    {
        Field = field;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Kunskapsområde: {Field}";
    }

    public bool AddCourse(Course newCourse)
    {
        foreach (var course in Courses)
        {
            if (course.CourseNumber == newCourse.CourseNumber)
            {
                return false;
            }
        }

        Courses.Add(newCourse);
        return true;
    }
}
