using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Camille;
using Camille.Enums;
using Camille.RiotGames.AccountV1;
using Camille.RiotGames.MatchV5;
using Camille.RiotGames;

public class APIHandler
{
    private const PlatformRoute platform = PlatformRoute.NA1;
    private const RegionalRoute region = RegionalRoute.AMERICAS;
    private readonly RiotGamesApi _api;

    public APIHandler(string apiKey)
    {
        _api = RiotGamesApi.NewInstance(apiKey);
    }
    #region GetSummoner
    public Summoner? GetSummoner(string gameName, string tagLine, string platformRegion)
    {
        try
        {
            var account = _api.AccountV1().GetByRiotId(region, gameName, tagLine);
            if (account == null) return null;
            var summoner = _api.AccountV1().GetByPuuid(region, account.Puuid);
            return new Summoner(gameName, tagLine, account.Puuid, platformRegion);
        }
        catch
        {
            return null;
        }
    }
    #endregion
    #region GetMatchData
    public (List<MatchData> Ranked, List<MatchData> Normal) CategorizeMatches(List<MatchData> matches)
    {
        var ranked = matches.Where(m => m.QueueType == "SUMMONERS_RIFT_5V5_RANKED_SOLO").ToList();
        var normal = matches.Where(m => m.QueueType == "SUMMONERS_RIFT_5V5_DRAFT_PICK").ToList();
        return (ranked, normal);
    }

    public List<string> GetMatchIds(string puuid, int count = 50)
    {
        try
        {
            return _api.MatchV5().GetMatchIdsByPUUID(RegionalRoute.AMERICAS, puuid, count: count)?.ToList() ?? new List<string>();
        }
        catch
        {
            return new List<string>();
        }
    }

    public List<MatchData> GetMatchDataList(string puuid, List<string> matchIds)
    {
        var matchDataList = new List<MatchData>();

        foreach (var matchId in matchIds)
        {
            try
            {
                var match = _api.MatchV5().GetMatch(RegionalRoute.AMERICAS, matchId);
                if (match == null) return new List<MatchData>();
                var participant = match.Info.Participants.FirstOrDefault(p => p.Puuid == puuid);

                if (participant != null)
                {
                    var queueType = match.Info.QueueId.ToString();
                    var data = new MatchData(
                        participant.Kills,
                        participant.Deaths,
                        participant.Assists,
                        participant.TotalDamageDealtToChampions,
                        participant.Win,
                        participant.TotalMinionsKilled,
                        participant.VisionScore,
                        queueType
                    );
                    matchDataList.Add(data);
                }
            }
            catch 
            {
                return new List<MatchData>();
            }
        }

        return matchDataList;
    }
    #endregion
}
