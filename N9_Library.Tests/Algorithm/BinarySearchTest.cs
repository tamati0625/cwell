using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_Library.Algorithm;

namespace N9_Library.Tests.Algorithm;

[TestClass]
[TestSubject(typeof(BinarySearch))]
public class BinarySearchTest
{
    [TestMethod]
    public void FindNumber_Return_Negative_1_When_TargetNumber_Not_Found()
    {
        BinarySearch rbs = new BinarySearch();

        List<int> numbers = [1, 3, 5, 0, 2, 4];
        numbers.Sort();
        int i = rbs.FindNumber(numbers, 6, 0, numbers.Count - 1);

        Assert.AreEqual(-1, i);
    }

    [TestMethod]
    public void FindNumber_Return_Negative_Index_When_TargetNumber_Found()
    {
        BinarySearch rbs = new BinarySearch();

        List<int> numbers = [1, 3, 5, 0, 2, 4];
        numbers.Sort();
        int i = rbs.FindNumber(numbers, 3, 0, numbers.Count - 1);

        Assert.AreEqual(3, i);
    }

    [TestMethod]
    public void FindNumber_Return_Negative_1_When_Start_Index_Greater_Than_End_Index()
    {
        BinarySearch rbs = new BinarySearch();

        List<int> numbers = [1, 3, 5, 0, 2, 4];

        int i = rbs.FindNumber(numbers, 5, 1, 0);

        Assert.AreEqual(-1, i);
    }

    [TestMethod]
    public void FindNumber()
    {
        BinarySearch bs = new BinarySearch();

        List<int> numbers = [1, 3, 5, 0, 2, 4];
        numbers.Sort();
        Assert.AreEqual(-1, bs.FindNumber(null, 5));
        Assert.AreEqual(0, bs.FindNumber(numbers, 0));
        Assert.AreEqual(1, bs.FindNumber(numbers, 1));
        Assert.AreEqual(2, bs.FindNumber(numbers, 2));
        Assert.AreEqual(3, bs.FindNumber(numbers, 3));
        Assert.AreEqual(4, bs.FindNumber(numbers, 4));
        Assert.AreEqual(5, bs.FindNumber(numbers, 5));
    }
}