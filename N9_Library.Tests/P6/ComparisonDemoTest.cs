using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_Library.P6;

namespace N9_Library.Tests.P6;

[TestClass]
[TestSubject(typeof(ComparisonDemo))]
public class ComparisonDemoTest
{
    [TestMethod]
    public void Compare()
    {
        Assert.AreEqual(ComparisonDemo.Compare("hello", "world"), 0);
    }


    [TestMethod]
    public void Sort()
    {
        List<string> animals = ["mouse", "cat", "elephant", "dog"];
        animals.Sort(ComparisonDemo.Compare);
        List<string> expected = ["cat", "dog", "mouse", "elephant"];


        CollectionAssert.AreEqual(expected, animals);
    }
}