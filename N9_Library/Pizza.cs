using System.Numerics;

namespace N9_Library;

public class Pizza : IComparable<Pizza>
{
    private decimal _retailPrice;

    public decimal RetailPrice => _retailPrice;

    private List<RecipeItem> _recipeItems;

    public Pizza(decimal retailPrice)
    {
        _retailPrice = retailPrice;
        _recipeItems = new List<RecipeItem>();
    }

    public void AddRecipeItem(RecipeItem recipeItem)
    {
        _recipeItems.Add(recipeItem);
    }

    public BigInteger TotalEnergy
    {
        get
        {
            BigInteger total = 0;
            foreach (RecipeItem recipeItem in _recipeItems)
            {
                total += recipeItem.Ingredient.EnergyValue;
            }

            return total;
        }
    }

    public bool IsVegetarian()
    {
        foreach (RecipeItem recipeItem in _recipeItems)
        {
            if (!recipeItem.Ingredient.VegetarianStatus)
            {
                return false;
            }
        }

        return true;
    }

    public int CompareTo(Pizza? other)
    {
        if (other == null)
        {
            return -1;
        }

        return _retailPrice.CompareTo(other._retailPrice);
    }
}