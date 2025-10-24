namespace N9_Library;

public class Ingredient
{
    private int _energyValue;

    public Ingredient(int energyValue, bool vegetarianStatus)
    {
        _energyValue = energyValue;
        VegetarianStatus = vegetarianStatus;
    }

    public int EnergyValue
    {
        get => _energyValue;
        set => _energyValue = value;
    }

    public bool VegetarianStatus { get; }
}