internal class OpponetsFactory
{
    private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());

    public Opponent[] Create(IEnumerable<Knight> knights)
    {
        var participants = knights.ToList();
        var opponents = new List<Opponent>();

        while (participants.Count > 1)
        {
            var attacker = GetParticipant(participants);
            participants.Remove(attacker);

            var deffender = GetParticipant(participants);
            participants.Remove(deffender);

            opponents.Add(new Opponent(attacker,deffender));
        }

        return opponents.ToArray();
    }

    private Knight GetParticipant(List<Knight> knights)
    {
        var participantIndex = _random.Next(knights.Count);

        return knights[participantIndex];
    }
}