using System;

namespace WestcoastEducation.Models;

public class Schedule
{
    public DateOnly StartDate { get; }
    public DateOnly EndDate { get; }

    public Schedule(DateOnly startDate, DateOnly endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
    }
}
