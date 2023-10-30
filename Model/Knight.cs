
public class Knight
{
    public Knight(string name, int healtPoints, int damange)
    {
        Name = name;
        HealtPoints = healtPoints;
        Damange = damange;
    }

    public string Name { get; private set; }
    public int HealtPoints { get; private set; }
    public int Damange { get; private set; }
    public bool IsDied => HealtPoints <= 0;

    public void TakeDamange(int damange)
    {
        if(damange < 0)
            throw new InvalidOperationException(nameof(damange));
        if (HealtPoints <= 0)
            throw new InvalidOperationException(nameof(HealtPoints));
        HealtPoints -= damange;
    }

    public void DamangeIncremment()
    {
        Damange++;
    }
}