namespace N9_CL_Program_Tutorials.P11;

public class MathUtil
{
    public static string ConvertToBaseString(int number, int base_number)
    {
        if (number <= 0)
        {
            return "0";
        }

        if (number < base_number)
        {
            return number.ToString();
        }

        int digit = number % base_number;

        return ConvertToBaseString(number / base_number, base_number) + digit.ToString();
    }
}