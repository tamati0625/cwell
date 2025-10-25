namespace N9_Library;

public class Hobbit
{
    private readonly string _name;
    public Hobbit Uncle { get; set; }

    public Hobbit(string name)
    {
        _name = name;
    }

    public Hobbit(string name, Hobbit uncle)
    {
        _name = name;
        Uncle = uncle;
    }

    public override string ToString()
    {
        return _name + " [" + Uncle._name + "]";
    }
}