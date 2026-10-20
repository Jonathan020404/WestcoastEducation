using System;
using System.Collections.Generic;
using System.IO;
using WestcoastEducation.Models;
using WestcoastEducation.Repositories;

namespace WestcoastEducation.Services;

public class CourseService
{
    private readonly List<Course> _courses = [];

    private readonly string _path = Directory.GetCurrentDirectory() + "/Data/courses.json";

    private readonly Storage<Course> _storage = new();

    public CourseService()
    {
        if (File.Exists(_path))
        {
            _courses = _storage.Read(_path);
        }
    }

    public void AddCourse(Course newCourse)
    {
        foreach (var course in _courses)
        {
            if (course.CourseNumber == newCourse.CourseNumber)
            {
                Console.WriteLine("Kursen finns redan");
                return;
            }
        }

        _courses.Add(newCourse);
        _storage.Write(_path, _courses);
    }

    public List<Course> GetCourses()
    {
        return _courses;
    }
}
