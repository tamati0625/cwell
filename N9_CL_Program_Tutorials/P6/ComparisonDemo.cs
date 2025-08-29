namespace N9_CL_Program_Tutorials.P6;

public class ComparisonDemo
{
    public static readonly Comparison<String> Compare = (s1, s2) => s1.Length - s2.Length;
}