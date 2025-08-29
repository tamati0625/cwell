using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_CL_Program_Tutorials.P6;

namespace N9_CL_Program_Tutorials.Tests.P6;

[TestClass]
[TestSubject(typeof(PredicateDemo))]
public class PredicateDemoTest
{
    [TestMethod]
    public void Checking()
    {
        Assert.IsTrue(PredicateDemo.Checking("lesson"));
    }


    [TestMethod]
    public void FindAll()
    {
        List<String> fruit = ["apple", "banana", "lemon", "grape"];
        Assert.AreEqual(fruit.FindAll(PredicateDemo.Checking).Count, 2);
    }
}