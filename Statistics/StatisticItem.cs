public class StatisticItem
{
    public StatisticItem(Knight attaker, Knight deffender)
    {
        Deffender = deffender;
        Attaker = attaker;
    }

    public Knight Attaker { get; }
    public Knight Deffender { get; }
    public int ApplaiedDamange { get; private set; }
    public int Winns { get; private set; }

    public void AddDammanged(int damange)
    {
        ApplaiedDamange += damange;
    }
    public void WinnsIncremment()
    {
        Winns ++;
    }
}
