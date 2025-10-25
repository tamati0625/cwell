using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N9_Library.Tests;

[TestClass]
[TestSubject(typeof(RecursionDemo))]
public class RecursionDemoTest
{
    [TestMethod]
    public void Factorial()
    {
        Assert.IsTrue(6 == RecursionDemo.Factorial(3));
        Assert.IsTrue(24 == RecursionDemo.Factorial(4));
        Assert.IsTrue(120 == RecursionDemo.Factorial(5));
    }

    [TestMethod]
    public void Test_Ascending()
    {
        int[] a1 = [2, 2, 4, 19];
        int[] a2 = [7, 9, 6, 11];

        Assert.IsTrue(RecursionDemo.IsAscending(a1, 0));
        Assert.IsFalse(RecursionDemo.IsAscending(a2, 0));
    }
}