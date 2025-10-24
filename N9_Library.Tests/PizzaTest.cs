using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N9_Library.Tests;

[TestClass]
[TestSubject(typeof(Pizza))]
public class PizzaTest
{
    [TestMethod]
    public void Test_PIzza()
    {
        Ingredient ingredient1 = new Ingredient(1, false);
        Ingredient ingredient2 = new Ingredient(2, true);
        Ingredient ingredient3 = new Ingredient(3, true);
        Ingredient ingredient4 = new Ingredient(4, true);
        Ingredient ingredient5 = new Ingredient(5, true);

        Pizza hawaiian = new Pizza(20);
        hawaiian.AddIngredient(ingredient1);
        hawaiian.AddIngredient(ingredient2);
        hawaiian.AddIngredient(ingredient3);
        hawaiian.AddIngredient(ingredient4);
        hawaiian.AddIngredient(ingredient5);
        
        Assert.AreEqual(15, hawaiian.TotalEnergy);
        Assert.IsFalse(hawaiian.IsVegetarian());
        
        Pizza pepperroni = new Pizza(10);
        pepperroni.AddIngredient(ingredient2);
        pepperroni.AddIngredient(ingredient3);
        pepperroni.AddIngredient(ingredient4);
        pepperroni.AddIngredient(ingredient5);

        Assert.AreEqual(14, pepperroni.TotalEnergy);
        Assert.IsTrue(pepperroni.IsVegetarian());

        List<Pizza> pizzas = [hawaiian, pepperroni];
        pizzas.Sort();
        
        Assert.AreEqual(10, pizzas[0].RetailPrice);
        Assert.AreEqual(20, pizzas[1].RetailPrice);
    }
}