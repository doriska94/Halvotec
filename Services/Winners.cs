internal class Winners
{
    private Stack<Knight> _knights = new Stack<Knight>();

    public void Add(Knight knight)
    {
        _knights.Push(knight);
    }
    public Knight[] GetWinners()
    {
        return _knights.ToArray();
    }
}