using N9_Library.DataStructure;

namespace N9_Library.Algorithm;

public class BinarySearch
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

    public int FindNumber(List<int>? numbers, int target)
    {
        if (Lists.IsEmpty(numbers))
        {
            return -1;
        }

        int low = 0;
        int high = numbers.Count - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (target > numbers[mid])
            {
                low = mid + 1;
                continue;
            }

            if (target < numbers[mid])
            {
                high = mid - 1;
                continue;
            }

            return mid;
        }

        return -1;
    }
}