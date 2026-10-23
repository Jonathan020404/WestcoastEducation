namespace WestcoastEducation.Models;

public class Teacher(
    string firstName,
    string lastName,
    string phoneNumber,
    string identityNumber,
    string field
) : Person(firstName, lastName, phoneNumber, identityNumber)
{
    public string Field { get; set; } = field;

    public List<Course> Courses { get; set; } = new();

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
