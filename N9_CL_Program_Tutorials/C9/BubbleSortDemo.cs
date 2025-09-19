namespace N9_CL_Program_Tutorials.C9;

public class BubbleSortDemo
{
    public void Sort(int[] numbers)
    {
        for (int i = numbers.Length - 1; i > 0; i--)
        {
            bool flag = false;
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    flag = true;
                }
            }

            if (!flag)
            {
                break;
            }
        }
    }
}