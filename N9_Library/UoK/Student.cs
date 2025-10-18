namespace N9_Library.UoK;

public class Student : Person
{
    private int _age;
    private List<Paper> _papers = new List<Paper>();

    protected Student(int age, string name) : base(name)
    {
        this._age = age;
    }

    public int Age => _age;

    public void AddPaper(Paper paper)
    {
        _papers.Add(paper);
    }

    public override string ToString()
    {
        return _age.ToString();
    }
}