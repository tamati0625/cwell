namespace N9_Library.UoK;

public sealed class Paper
{
    private List<Student> _students = new List<Student>();

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }
}