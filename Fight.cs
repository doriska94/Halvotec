internal class Fight
{
    private readonly IAttackRandom _attackRandom;
    private readonly IStatistic _statistic;

    public Fight(IAttackRandom attackRandom, IStatistic statistic)
    {
        _attackRandom = attackRandom;
        _statistic = statistic;
    }

    public bool TryAttack(Opponent opponent)
    {
        var attackerPosibility = _attackRandom.GetAttackPosibility(opponent.Attacker);
        var defenderPosibility = _attackRandom.GetAttackPosibility(opponent.Attacker);

        var damange = attackerPosibility - defenderPosibility;
        if (damange <= 0)
            return false;

        opponent.ApplayDamnage(damange);
        _statistic.Add(opponent, damange);

        return true;
    }
}
