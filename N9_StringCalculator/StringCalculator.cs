namespace N9_StringCalculator;

public class StringCalculator
{
    public int Add(string numbers)
    {
        return numbers == string.Empty ? 0 : numbers.Split(',').Select(int.Parse).Sum();
    }
}