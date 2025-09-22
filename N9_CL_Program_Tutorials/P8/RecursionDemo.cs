namespace N9_CL_Program_Tutorials.P8;

public class RecursionDemo
{
    public static int Factorial(int n)
    {
        // 2
        // f(1) * 2
        // return 1
        // return 1 * 2

        // 3
        // return f(2) * 3
        // return f(1) * 2
        // return 1
        // return 2
        // return 2 * 3
        // return 6

        // 4
        // return f(3) * 4
        // return f(2) * 3
        // return (1) * 2
        // return 1
        // return 2;
        // return 6
        // return 24

        if (n == 1 || n == 0)
            return 1;

        return Factorial(n - 1) * n;
    }
}