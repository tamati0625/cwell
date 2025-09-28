using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_Library.Algorithm;

namespace N9_Library.Tests.Algorithm;

[TestClass]
[TestSubject(typeof(BubbleSort))]
public class BubbleSortTest
{
    [TestMethod]
    public void Test_Bubble_Sort()
    {
        int[] numbers = [1, 4, 5, 6, 9, 8];
        BubbleSort.Sort(numbers);

        int[] expected = [1, 4, 5, 6, 8, 9];
        CollectionAssert.AreEqual(expected, numbers);
    }
}