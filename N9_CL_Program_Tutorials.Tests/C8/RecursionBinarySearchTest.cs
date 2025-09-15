using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_CL_Program_Tutorials.C8;

namespace N9_CL_Program_Tutorials.Tests.C8;

[TestClass]
[TestSubject(typeof(RecursionBinarySearch))]
public class RecursionBinarySearchTest
{
    [TestMethod]
    public void FindNumber_Return_Negative_1_When_TargetNumber_Not_Found()
    {
        RecursionBinarySearch rbs = new RecursionBinarySearch();

        List<int> numbers = [1, 3, 5, 0, 2, 4];
        numbers.Sort();
        int i = rbs.FindNumber(numbers, 6, 0, numbers.Count - 1);

        Assert.AreEqual(-1, i);
    }

    [TestMethod]
    public void FindNumber_Return_Negative_Index_When_TargetNumber_Found()
    {
        RecursionBinarySearch rbs = new RecursionBinarySearch();

        List<int> numbers = [1, 3, 5, 0, 2, 4];
        numbers.Sort();
        int i = rbs.FindNumber(numbers, 3, 0, numbers.Count - 1);

        Assert.AreEqual(3, i);
    }

    [TestMethod]
    public void FindNumber_Return_Negative_1_When_Start_Index_Greater_Than_End_Index()
    {
        RecursionBinarySearch rbs = new RecursionBinarySearch();

        List<int> numbers = [1, 3, 5, 0, 2, 4];

        int i = rbs.FindNumber(numbers, 5, 1, 0);

        Assert.AreEqual(-1, i);
    }
}