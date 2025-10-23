using System.Collections.Generic;

namespace N9_Library.Tests.DataStructure;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ArrayTest
{
    [TestMethod]
    public void Test_Array()
    {
        int[] numbers = [1, 4, 10, 15, 17, 22, 30, 52];

        int[] subArray = numbers[..3];

        int[] expected = [1, 4, 10];
        
        CollectionAssert.AreEqual(expected, subArray);
    }
}