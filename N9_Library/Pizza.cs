using System.Numerics;

namespace N9_Library;

public class Pizza : IComparable<Pizza>
{
    private decimal _retailPrice;

    public decimal RetailPrice => _retailPrice;

    private List<Ingredient> _ingredients;

    public Pizza(decimal retailPrice)
    {
        _retailPrice = retailPrice;
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

    public int CompareTo(Pizza? other)
    {
        if (other == null)
        {
            return -1;
        }

        return _retailPrice.CompareTo(other._retailPrice);
    }
}