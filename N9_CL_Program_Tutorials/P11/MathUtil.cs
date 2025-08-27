namespace N9_CL_Program_Tutorials.P11;

public class MathUtil
{
    public static string Mystery(int number)
    {
        if (number <= 0)
        {
            return "0";
        }

        int digit = number % 2;

        return Mystery(number / 2) + digit.ToString();
    }
}