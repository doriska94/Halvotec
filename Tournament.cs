internal class Tournament
{

    private readonly OpponetsFactory _opponetsFactory;
    private readonly Fight _fight;
    private readonly Winners _winners;
    private readonly IStatistic _statistic;
    public Tournament(OpponetsFactory opponetsFactory, Fight fight, Winners winners, IStatistic statistic)
    {
        _opponetsFactory = opponetsFactory;
        _fight = fight;
        _winners = winners;
        _statistic = statistic;
    }

    public void Start(IEnumerable<Knight> knights)
    {
        var particpants = knights.ToList();
        var winners = new List<Knight>();

        while (particpants.Count > 1)
        {
            var opponets = _opponetsFactory.Create(particpants);

            foreach (var opponent in opponets)
            {
                var wasAttacked = _fight.TryAttack(opponent);
                if (wasAttacked)
                {
                    opponent.IncrementAttackerDammange();
                    if (opponent.Defender.IsDied)
                        _statistic.AddWinn(opponent);
                }
            }

            if (particpants.Count <= 3)
            {
                var opponet = opponets.First();

                if (opponet.Defender.IsDied)
                    _winners.Add(opponet.Defender);
            }

            particpants.RemoveAll(x => x.IsDied);
        }
        _winners.Add(particpants.First());
    }
}
