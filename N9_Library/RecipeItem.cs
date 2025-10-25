namespace N9_Library;

public class RecipeItem
{
    public Ingredient Ingredient { get; }
    public int Quantity { get; }

    public RecipeItem(int quantity, Ingredient ingredient)
    {
        Ingredient = ingredient;
        Quantity = quantity;
    }
}