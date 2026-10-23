using WestcoastEducation.Models;

namespace WestcoastEducation.Services;

public class PersonService
{
    private readonly List<Student> _students = [];
    private readonly List<Teacher> _teachers = [];
    private readonly List<EducationManager> _educationManagers = [];
    private readonly List<Administrator> _administrators = [];

    public void AddStudent(Student newStudent)
    {
        foreach (var student in _students)
        {
            if (student.IdentityNumber == newStudent.IdentityNumber)
            {
                Console.WriteLine("Studenten finns redan");
                return;
            }
        }

        _students.Add(newStudent);
    }

    public void AddTeacher(Teacher newTeacher)
    {
        foreach (var teacher in _teachers)
        {
            if (teacher.IdentityNumber == newTeacher.IdentityNumber)
            {
                Console.WriteLine("Läraren finns redan");
                return;
            }
        }

        _teachers.Add(newTeacher);
    }

    public void AddEducationManager(EducationManager newEducationManager)
    {
        foreach (var manager in _educationManagers)
        {
            if (manager.IdentityNumber == newEducationManager.IdentityNumber)
            {
                Console.WriteLine("Utbildningsledaren finns redan");
                return;
            }
        }

        _educationManagers.Add(newEducationManager);
    }

    public void AddAdministrator(Administrator newAdministrator)
    {
        foreach (var administrator in _administrators)
        {
            if (administrator.IdentityNumber == newAdministrator.IdentityNumber)
            {
                Console.WriteLine("Administratören finns redan");
                return;
            }
        }

        _administrators.Add(newAdministrator);
    }

    public List<Student> GetStudents()
    {
        return _students;
    }

    public List<Teacher> GetTeachers()
    {
        return _teachers;
    }

    public List<EducationManager> GetEducationManagers()
    {
        return _educationManagers;
    }

    public List<Administrator> GetAdministrators()
    {
        return _administrators;
    }
}
