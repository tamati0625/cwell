using System.Collections.Generic;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N9_Library.Tests.Types;

[TestClass]
public class BigIntegerTest
{
    [TestMethod]
    public void Test_BigInt()
    {
        BigInteger sum = 0;
        List<int> numbers = [1, 2, 3, 4, 5];
        foreach (int n in numbers)
        {
            sum += n;
        }

        Assert.AreEqual(15, sum);
    }
}