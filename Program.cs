
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

int knightCount = 0;

do
{
    Console.Write("Anzahl Ritter: ");

} while (int.TryParse(Console.ReadLine(), out knightCount) == false);

int healtPoints = 0;

do
{
    Console.Write("Lebenspunkte: ");

} while (int.TryParse(Console.ReadLine(), out healtPoints) == false);


var knights = KnightFactory.Create(knightCount, healtPoints);

var attackRandom = new AttackRandom();
var statistic = new Statistic();

var fight = new Fight(attackRandom, statistic);

var oppponentsFactory = new OpponetsFactory();
var winners = new Winners();

var tournament = new Tournament(oppponentsFactory, fight, winners, statistic);

tournament.Start(knights);

foreach (var statisticItem in statistic.StatisticItems)
{
    Console.WriteLine($"\"{statisticItem.Attaker.Name}\" hat \"{statisticItem.Deffender.Name}\" => {statisticItem.ApplaiedDamange} Lebenspunkte abgezogen");
}

Console.WriteLine();

foreach (var knight in knights)
{
    Console.WriteLine($"\"{knight.Name}\" : Lebenspunkt {knight.HealtPoints} Angriffstärke : {knight.Damange}");
}

Console.WriteLine();

var winnerKnights = winners.GetWinners();

for (int i = 0; i < winnerKnights.Length; i++)
{
    var winnCount = statistic.GetWinnsCount(winnerKnights[i]);
    Console.WriteLine($"Platz {i + 1}: {winnerKnights[i].Name} : hat {winnCount} gegner geschlagen");
}

Console.Read();
