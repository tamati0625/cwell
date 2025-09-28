using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_Library.P8;

namespace N9_Library.Tests.P8;

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
}