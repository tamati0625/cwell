tuple deconstruction to swap two adjacent elementsusing System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_CL_Program_Tutorials.C9;

namespace N9_CL_Program_Tutorials.Tests.C9;

[TestClass]
[TestSubject(typeof(BubbleSortDemo))]
public class BubbleSortDemoTest
{

    [TestMethod]
    public void Test_Bubble_Sort()
    {
        BubbleSortDemo bs = new BubbleSortDemo();
        int[] numbers = [1, 4, 5, 6, 9, 8];
        bs.Sort(numbers);

        int[] expected = [1, 4, 5, 6, 8, 9];
        CollectionAssert.AreEqual(expected, numbers);
    }
}