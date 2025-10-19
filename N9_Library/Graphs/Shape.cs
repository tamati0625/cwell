using System.Reflection.Metadata;

namespace N9_Library.Graphs;

public abstract class Shape
{
    private const decimal Constant1 = 0;
    private static decimal Static1;
    public abstract void Method();

    public virtual void Method1()
    {
        Shape.Static1 = 1;
    }
}