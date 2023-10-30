public class Opponent
{
    public Opponent(Knight attacker, Knight defender)
    {
        Attacker = attacker;
        Defender = defender;
    }

    public  Knight Attacker { get;  }
    public  Knight Defender { get;  }

    public void ApplayDamnage(int damange)
    {
        Defender.TakeDamange(damange);
    }
    public void IncrementAttackerDammange()
    {
        Attacker.DamangeIncremment();
    }
}