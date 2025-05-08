using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MatchDataSummary
{
    #region Properties
    public double AverageKills { get; private set; }
    public double AverageDeaths { get; private set; }
    public double AverageAssists { get; private set; }
    public double AverageDamageDealt { get; private set; }
    public double AverageKDA { get; private set; }
    public double WinRate { get; private set; }
    public double AverageCS { get; private set; }
    public double AverageVS { get; private set; }
    #endregion

    public void CalculateFromMatches(List<MatchData> matches)
    {
        if (matches.Count == 0) return;

        AverageKills = matches.Average(m => m.Kills);
        AverageDeaths = matches.Average(m => m.Deaths);
        AverageAssists = matches.Average(m => m.Assists);
        AverageDamageDealt = matches.Average(m => m.DamageDealt);
        AverageKDA = matches.Average(m => m.CalculateKDA());
        AverageCS = matches.Average(m => m.CreepScore);
        AverageVS = matches.Average(m => m.VisionScore);
        WinRate = matches.Count(m => m.Win) / (double)matches.Count * 100.0;
    }

    public override string ToString()
    {
        return $"Kills: {AverageKills:F1}, Deaths: {AverageDeaths:F1}, Assists: {AverageAssists:F1}, " +
               $"Damage: {AverageDamageDealt:F0}, KDA: {AverageKDA:F2}, CS: {AverageCS:F1}, Vision Score: {AverageVS:F1} Win Rate: {WinRate:F1}%";
    }
}
