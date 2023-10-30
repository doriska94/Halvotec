internal class KnightFactory
{
    public const int DefaultKnightDamange = 6;
    public static Knight[] Create(int knightsCount, int healtPoint)
    {
        string knightNameTamplate = "Ritter ";
        var knights = new List<Knight>();

        for (int i = 1; i <= knightsCount; i ++)
        {
            knights.Add(new Knight(knightNameTamplate + i , healtPoint, DefaultKnightDamange));
        }

        return knights.ToArray();
    }
}
