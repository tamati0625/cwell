namespace N9_Library;

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

    public static bool IsAscending(int[] array, int startIndex)
    {
        if (array is null or { Length: <= 1 } || startIndex == array.Length - 1)
        {
            return true;
        }

        int next = startIndex + 1;
        if (array[startIndex] <= array[next])
        {
            return IsAscending(array, next);
        }

        return false;
    }
}