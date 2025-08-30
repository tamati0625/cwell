using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_CL_Program_Tutorials.P8;

namespace N9_CL_Program_Tutorials.Tests.P8;

[TestClass]
[TestSubject(typeof(RecursionDemo))]
public class RecursionDemoTest
{
    [TestMethod]
    public void Factorial()
    {
        int actual = RecursionDemo.Factorial(3);

        Assert.IsTrue(6 == actual);
    }
}