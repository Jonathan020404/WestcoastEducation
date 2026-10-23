namespace WestcoastEducation.Models;

public class Schedule(DateOnly startDate, DateOnly endDate)
{
    public DateOnly StartDate { get; } = startDate;
    public DateOnly EndDate { get; } = endDate;
}
