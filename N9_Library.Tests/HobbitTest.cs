using System.ComponentModel;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_Library;

namespace N9_Library.Tests;

[TestClass]
[TestSubject(typeof(Hobbit))]
public class HobbitTest
{
    [TestMethod]
    public void Test()
    {
        BindingList<Hobbit> shire = new BindingList<Hobbit>();

        Hobbit h1 = new Hobbit("Bilbo");
        shire.Add(h1);

        Hobbit h2 = new Hobbit("Frodo", h1);
        shire.Add(h2);

        h1 = new Hobbit("Sam", h2);
        shire.Add(h1);

        h2 = h2.Uncle;
        h2.Uncle = h1; // here, the value in the memory address is changed.
        shire.Add(h2);

        Assert.AreEqual(4, shire.Count);

        Assert.AreEqual("Bilbo [Sam]", shire[0].ToString());
        Assert.AreEqual("Frodo [Bilbo]", shire[1].ToString());
        Assert.AreEqual("Sam [Frodo]", shire[2].ToString());
        Assert.AreEqual("Bilbo [Sam]", shire[3].ToString());
    }
}