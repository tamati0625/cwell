using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N9_Library.Animals;

namespace N9_Library.Tests.Animals;

[TestClass]
[TestSubject(typeof(Pet))]
public class PetTest
{
    [TestMethod]
    public void Test_IS()
    {
        Pet p1 = new Pet("p1");
        Pet p2 = new Beagle("p2");
        Cat p3 = new Cat("p3");

        Dog d1 = (Dog)p2;
        Pet p4 = (Pet)p3;
        Beagle p5 = (Beagle)p1;        

        Assert.AreEqual(true, p1 is Pet);
        Assert.AreEqual(false, p1 is Dog);
        Assert.AreEqual(true, p2 is Dog);
        Assert.AreEqual(true, p2 is Beagle);
        Assert.AreEqual(true, p3 is Pet);
        Assert.AreEqual(true, p3 is object);
    }
}