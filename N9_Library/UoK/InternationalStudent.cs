namespace N9_CL_Class_Examples.UoK;

public class InternationalStudent : Student
{
    private string _passport;

    private InternationalStudent(string passport, string name) : base(1, name)
    {
        this._passport = passport;
    }

    public String TestMethod()
    {
        return _passport;
    }
}