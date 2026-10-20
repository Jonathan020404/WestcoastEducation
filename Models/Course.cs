using System;
using System.Text.Json.Serialization;

namespace WestcoastEducation.Models;

public class Course
{
    public string CourseNumber { get; set; }
    public string Title { get; set; }
    public CourseType CourseType { get; set; }
    public int WeekAmount { get; set; }
    public Schedule Schedule { get; }

    public Course(
        string courseNumber,
        string title,
        CourseType courseType,
        int weekAmount,
        DateOnly startDate,
        DateOnly endDate
    )
    {
        CourseNumber = courseNumber;
        Title = title;
        CourseType = courseType;
        WeekAmount = weekAmount;

        Schedule = new Schedule(startDate, endDate);
    }

    [JsonConstructor]
    public Course(
        string courseNumber,
        string title,
        CourseType courseType,
        int weekAmount,
        Schedule schedule
    )
    {
        CourseNumber = courseNumber;
        Title = title;
        CourseType = courseType;
        WeekAmount = weekAmount;
        Schedule = new Schedule(schedule.StartDate, schedule.EndDate);
    }

    public string GetInfo()
    {
        return $"Kursnummer: {CourseNumber}, Titel: {Title}, Schema: Från {Schedule.StartDate} till {Schedule.EndDate}";
    }
}
