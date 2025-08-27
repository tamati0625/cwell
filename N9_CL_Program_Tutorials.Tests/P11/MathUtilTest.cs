using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_CL_Program_Tutorials.P11;

namespace N9_CL_Program_Tutorials.Tests.P11;

[TestClass]
[TestSubject(typeof(MathUtil))]
public class MathUtilTest
{
    [TestMethod]
    public void Mystery()
    {
        Assert.AreEqual(MathUtil.Mystery(0), "0");
        Assert.AreEqual(MathUtil.Mystery(-1), "0");
        Assert.AreEqual(MathUtil.Mystery(15), "01111");
        Assert.AreEqual(MathUtil.Mystery(16), "010000");
    }
}