using WestcoastEducation.Models;
using WestcoastEducation.Services;

namespace WestcoastEducation;

class Program
{
    static void Main()
    {
        PersonService personService = new();
        CourseService courseService = new();

        Console.WriteLine("Westcoast Education");

        Course course1 = new(
            "C101",
            "C# Grundkurs",
            CourseType.Classroom,
            4,
            new DateOnly(2026, 11, 2),
            new DateOnly(2026, 11, 27)
        );

        Course course2 = new(
            "C102",
            "Webbutveckling",
            CourseType.Remote,
            4,
            new DateOnly(2027, 1, 11),
            new DateOnly(2027, 2, 5)
        );

        Student student1 = new("Erik", "Svensson", "0701234567", "200001011234");

        Student student2 = new("Sara", "Andersson", "0709876543", "200203152345");

        Teacher teacher = new("Anna", "Karlsson", "0701112233", "198505151234", "Systemutveckling");

        EducationManager manager = new(
            "Maria",
            "Johansson",
            "0702223344",
            "197806102345",
            "IT-utbildning",
            new DateOnly(2020, 8, 15)
        );

        Administrator admin = new(
            "Peter",
            "Nilsson",
            "0703334455",
            "198209202345",
            "Administration",
            new DateOnly(2022, 3, 1)
        );

        course1.AddStudent(student1);
        course1.AddStudent(student2);

        courseService.AddCourse(course1);
        courseService.AddCourse(course2);

        personService.AddStudent(student1);
        personService.AddStudent(student2);
        personService.AddTeacher(teacher);
        personService.AddEducationManager(manager);
        personService.AddAdministrator(admin);

        teacher.Courses.Add(course1);
        teacher.Courses.Add(course2);

        Console.WriteLine("Kurser: ");
        foreach (var course in courseService.GetCourses())
        {
            Console.WriteLine(course.GetInfo());
        }

        Console.WriteLine("Studenter: ");
        foreach (var student in personService.GetStudents())
        {
            Console.WriteLine(student.GetInfo());
        }

        Console.WriteLine("Lärare: ");
        foreach (var item in personService.GetTeachers())
        {
            Console.WriteLine(item.GetInfo());

            Console.WriteLine("Lärarens kurser: ");
            foreach (var course in item.Courses)
            {
                Console.WriteLine(course.GetInfo());
            }
        }

        Console.WriteLine("Utbildningsledare: ");
        foreach (var item in personService.GetEducationManagers())
        {
            Console.WriteLine(item.GetInfo());
        }

        Console.WriteLine("Administratör: ");
        foreach (var item in personService.GetAdministrators())
        {
            Console.WriteLine(item.GetInfo());
        }
    }
}
