using System.Collections.Generic;

namespace N9_Library.Tests.DataStructure;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ListTest
{
    [TestMethod]
    public void Test_List()
    {
        List<int> numbers = [1, 4, 10, 15, 17, 22, 30, 52];

        List<int> sublist = numbers.GetRange(0, 3);

        List<int> expected = [1, 4, 10];
        
        CollectionAssert.AreEqual(expected, sublist);
    }
}