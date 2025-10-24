using System.Numerics;

namespace N9_Library;

public class Pizza
{
    private List<Ingredient> _ingredients;

    public Pizza()
    {
        _ingredients = new List<Ingredient>();
    }

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public BigInteger TotalEnergy
    {
        get
        {
            BigInteger total = 0;
            foreach (Ingredient ingredient in _ingredients)
            {
                total += ingredient.EnergyValue;
            }

            return total;
        }
    }

    public bool IsVegetarian()
    {
        foreach (Ingredient ingredient in _ingredients)
        {
            if (!ingredient.VegetarianStatus)
            {
                return false;
            }
        }

        return true;
    }
}