namespace N9_Library;

public class Plant
{
    private int _xpos;
    private int _ypost;
    private int _foliageSize;

    public int XPos
    {
        get => _xpos;
        set => _xpos = value;
    }

    public Plant(int xpos, int ypost, int foliageSize)
    {
        _xpos = xpos;
        _ypost = ypost;

        _foliageSize = Math.Clamp(foliageSize, 10, 30);
    }

    public void Grow(int amount)
    {
        _foliageSize = Math.Min(50, _foliageSize + amount);
    }
}