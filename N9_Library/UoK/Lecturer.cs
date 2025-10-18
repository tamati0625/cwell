namespace N9_Library.UoK;

public class Lecturer : Person, IAdministrator, ISupervisor
{
    private Lecturer(string name) : base(name)
    {
    }

    public List<Student> GetStudents()
    {
        throw new NotImplementedException();
    }

    public List<Project> GetProjects()
    {
        throw new NotImplementedException();
    }
}