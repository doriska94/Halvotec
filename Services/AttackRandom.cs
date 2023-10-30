
internal class AttackRandom : IAttackRandom
{
    private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
    public int GetAttackPosibility(Knight knight)
    {
        return _random.Next(knight.Damange);
    }
}
