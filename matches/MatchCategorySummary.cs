using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MatchCategorySummary
{
    public string CategoryName { get; set; }
    public MatchDataSummary Summary { get; set; }

    public MatchCategorySummary(string categoryName, List<MatchData> matches)
    {
        CategoryName = categoryName;
        Summary = new MatchDataSummary();
        Summary.CalculateFromMatches(matches);
    }

    public override string ToString()
    {
        return $"{CategoryName} Matches:\n{Summary}\n";
    }
}
