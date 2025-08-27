using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_CL_Program_Tutorials.P11;

namespace N9_CL_Program_Tutorials.Tests.P11;

[TestClass]
[TestSubject(typeof(MathUtil))]
public class MathUtilTest
{
    [TestMethod]
    public void ConvertToBaseString()
    {
        Assert.AreEqual(MathUtil.ConvertToBaseString(0, 2), "0");
        Assert.AreEqual(MathUtil.ConvertToBaseString(-1, 2), "0");
        Assert.AreEqual(MathUtil.ConvertToBaseString(1, 2), "1");
        Assert.AreEqual(MathUtil.ConvertToBaseString(15, 2), "1111");
        Assert.AreEqual(MathUtil.ConvertToBaseString(16, 2), "10000");
        Assert.AreEqual(MathUtil.ConvertToBaseString(0, 8), "0");
        Assert.AreEqual(MathUtil.ConvertToBaseString(-1, 8), "0");
        Assert.AreEqual(MathUtil.ConvertToBaseString(1, 8), "1");
        Assert.AreEqual(MathUtil.ConvertToBaseString(15, 8), "17");
        Assert.AreEqual(MathUtil.ConvertToBaseString(16, 8), "20");
        Assert.AreEqual(MathUtil.ConvertToBaseString(0, 16), "0");
        Assert.AreEqual(MathUtil.ConvertToBaseString(-1, 16), "0");
        Assert.AreEqual(MathUtil.ConvertToBaseString(1, 16), "1");
        Assert.AreEqual(MathUtil.ConvertToBaseString(15, 16), "15");
        Assert.AreEqual(MathUtil.ConvertToBaseString(16, 16), "10");
    }
}