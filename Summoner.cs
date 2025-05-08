using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Summoner
{
    #region Properties
    public string GameName { get; set; }
    public string TagLine { get; set; }
    public string Puuid { get; set; }
    public string Region { get; set; }
    #endregion

    public Summoner(string gameName, string tagLine, string puuid, string region)
    {
        GameName = gameName;
        TagLine = tagLine;
        Puuid = puuid;
        Region = region;
    }

    public void updateSummoner(string newName, string newTag, string newPuuid, string newRegion)
    {
        GameName = newName;
        TagLine = newTag;
        Puuid = newPuuid;
        Region = newRegion;
    }
}
