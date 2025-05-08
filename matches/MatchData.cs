using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MatchData
{
    #region Properties
    public double Kills { get; set; }
    public double Deaths { get; set; }
    public double Assists { get; set; }
    public double DamageDealt { get; set; }
    public bool Win { get; set; }
    public string QueueType { get; set; }
    public double CreepScore { get; set; }
    public double VisionScore { get; set; }
    #endregion

    public MatchData(double kills, double deaths, double assists, double damageDealt, bool win, double creepScore, double visionScore, string queueType)
    {
        Kills = kills;
        Deaths = deaths;
        Assists = assists;
        DamageDealt = damageDealt;
        Win = win;
        CreepScore = creepScore;
        VisionScore = visionScore;
        QueueType = queueType;
    }

    public double CalculateKDA()
    {
        return (Assists + Kills) / (Deaths == 0 ? 1 : Deaths);
    }
}
