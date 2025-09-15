namespace N9_CL_Program_Tutorials.C8;

public class RecursionBinarySearch
{
    public int FindNumber(List<int> numbers, int target, int startIndex, int endIndex)
    {
        if (startIndex > endIndex)
        {
            return -1;
        }

        int middleIndex = (startIndex + endIndex) / 2;

        if (numbers[middleIndex] == target)
        {
            return middleIndex;
        }

        if (numbers[middleIndex] > target)
        {
            return FindNumber(numbers, target, startIndex, middleIndex - 1);
        }

        return FindNumber(numbers, target, middleIndex + 1, endIndex);
    }
}