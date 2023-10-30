internal class Statistic : IStatistic, IStatisticItems
{
    private List<StatisticItem> _statistics = new List<StatisticItem>();

    public IEnumerable<StatisticItem> StatisticItems => _statistics;

    public void Add(Opponent opponent, int damange)
    {
        var statisticItem = _statistics.SingleOrDefault(x => x.Attaker == opponent.Attacker && x.Deffender == opponent.Defender);
        if (statisticItem == null)
        {
            statisticItem = new StatisticItem(opponent.Attacker, opponent.Defender);
            _statistics.Add(statisticItem);
        }

        statisticItem.AddDammanged(damange);
    }
    public void AddWinn(Opponent opponent)
    {
        var statisticItem = _statistics.SingleOrDefault(x => x.Attaker == opponent.Attacker && x.Deffender == opponent.Defender);
        if (statisticItem == null)
        {
            statisticItem = new StatisticItem(opponent.Attacker, opponent.Defender);
            _statistics.Add(statisticItem);
        }

        statisticItem.WinnsIncremment();
    }
    public int GetWinnsCount(Knight knight)
    {
        return _statistics.Where(x => x.Attaker == knight).Sum(x => x.Winns);
    }
}
