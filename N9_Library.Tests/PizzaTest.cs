using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N9_Library.Tests;

[TestClass]
[TestSubject(typeof(Pizza))]
public class PizzaTest
{
    [TestMethod]
    public void Test_Pizza()
    {
        Ingredient ingredient1 = new Ingredient(1, false);
        Ingredient ingredient2 = new Ingredient(2, true);
        Ingredient ingredient3 = new Ingredient(3, true);
        Ingredient ingredient4 = new Ingredient(4, true);
        Ingredient ingredient5 = new Ingredient(5, true);

        RecipeItem recipeItem1 = new RecipeItem(1, ingredient1);
        RecipeItem recipeItem2 = new RecipeItem(2, ingredient2);
        RecipeItem recipeItem3 = new RecipeItem(3, ingredient3);
        RecipeItem recipeItem4 = new RecipeItem(4, ingredient4);
        RecipeItem recipeItem5 = new RecipeItem(5, ingredient5);
        
        Pizza hawaiian = new Pizza(20);
        hawaiian.AddRecipeItem(recipeItem1);
        hawaiian.AddRecipeItem(recipeItem2);
        hawaiian.AddRecipeItem(recipeItem3);
        hawaiian.AddRecipeItem(recipeItem4);
        hawaiian.AddRecipeItem(recipeItem5);
        
        Assert.AreEqual(15, hawaiian.TotalEnergy);
        Assert.IsFalse(hawaiian.IsVegetarian());
        
        Pizza pepperroni = new Pizza(10);
        pepperroni.AddRecipeItem(recipeItem2);
        pepperroni.AddRecipeItem(recipeItem3);
        pepperroni.AddRecipeItem(recipeItem4);
        pepperroni.AddRecipeItem(recipeItem5);

        Assert.AreEqual(14, pepperroni.TotalEnergy);
        Assert.IsTrue(pepperroni.IsVegetarian());

        List<Pizza> pizzas = [hawaiian, pepperroni];
        pizzas.Sort();
        
        Assert.AreEqual(10, pizzas[0].RetailPrice);
        Assert.AreEqual(20, pizzas[1].RetailPrice);
    }
}