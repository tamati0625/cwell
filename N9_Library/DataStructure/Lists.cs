namespace N9_Library.DataStructure;

public static class Lists
{
    public static bool IsEmpty<T>(List<T>? list)
    {
        return list is null or { Count: 0 };
    }
}