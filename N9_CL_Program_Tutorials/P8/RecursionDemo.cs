namespace N9_CL_Program_Tutorials.P8;

public class RecursionDemo
{
    public static int Factorial(int n)
    {
        int i, result = 1;
        for (i = 2; i <= n; i++)
            result *= i;
        return result;
    }
}