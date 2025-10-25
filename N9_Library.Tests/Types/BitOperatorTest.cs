using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N9_Library.Tests.Types;

[TestClass]
public class BitOperatorTest
{
    [TestMethod]
    public void Test()
    {
        Assert.AreEqual(110, 102 | 104);
        Assert.AreEqual(96, 102 & 104);
        Assert.AreEqual(25, 102 >> 2);
    }
}