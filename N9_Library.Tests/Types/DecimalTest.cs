using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N9_Library.Tests.Types;

[TestClass]
public class DecimalTest
{
    [TestMethod]
    public void Test_Decimal()
    {
        string name = "Hawaiian";
        decimal price = 1.123210m;

        Assert.AreEqual("Hawaiian ($1.12)", name + " (" + price.ToString("C") + ")");
    }
}