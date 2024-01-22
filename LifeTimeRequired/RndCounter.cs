public class RandomCounter : ICounter
{
    static Random rnd = new();
    private int _value;
    public RandomCounter()
    {
        _value = rnd.Next(0, 15);
    }
    public int Value
    {
        get => _value;
    }
}