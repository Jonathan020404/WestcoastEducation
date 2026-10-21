using System;
using System.Text.Json.Serialization;

namespace WestcoastEducation.Models;

public class Course(
    string courseNumber,
    string title,
    CourseType courseType,
    int weekAmount,
    DateOnly startDate,
    DateOnly endDate
)
{
    public string CourseNumber { get; set; } = courseNumber;
    public string Title { get; set; } = title;
    public CourseType CourseType { get; set; } = courseType;
    public int WeekAmount { get; set; } = weekAmount;
    public DateOnly StartDate { get; } = startDate;
    public DateOnly EndDate { get; } = endDate;

    [JsonIgnore]
    public Schedule Schedule { get; } = new Schedule(startDate, endDate);

    public List<Student> Students { get; set; } = [];

    public bool AddStudent(Student newStudent)
    {
        foreach (var student in Students)
        {
            if (student.IdentityNumber == newStudent.IdentityNumber)
            {
                return false;
            }
        }

        Students.Add(newStudent);
        return true;
    }

    public string GetInfo()
    {
        return $"Kursnummer: {CourseNumber}, Titel: {Title}, Schema: Från {Schedule.StartDate} till {Schedule.EndDate}";
    }
}
