using System.Windows.Forms.DataVisualization.Charting;

namespace RiotApp
{
    public partial class RiotForm : Form
    {
        #region Variables
        private List<MatchData>? rankedMatches;
        private List<MatchData>? normalMatches;
        #endregion

        public RiotForm()
        {
            rankedMatches = null;
            normalMatches = null;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCharts();
            lblStatus.Text = "Ready to fetch data";
        }
        #region Other Methods
        private void DisplaySummary()
        {
            lstSummary.Items.Clear();

            if (rankedMatches != null && rankedMatches.Any())
            {
                var rankedSummary = new MatchCategorySummary("Ranked", rankedMatches);
                lstSummary.Items.Add(rankedSummary.ToString());
            }
            else
            {
                lstSummary.Items.Add("No ranked data available.");
            }

            if (normalMatches != null && normalMatches.Any())
            {
                var normalSummary = new MatchCategorySummary("Normal", normalMatches);
                lstSummary.Items.Add(normalSummary.ToString());
            }
            else
            {
                lstSummary.Items.Add("No normal data available.");
            }
        }

        private void InitializeCharts()
        {

            foreach (var chart in new[] { chartRanked, chartNormal })
            {
                chart.Series.Clear();
                chart.Titles.Clear();

                // Ensure the chart area exists
                if (chart.ChartAreas.Count == 0)
                    chart.ChartAreas.Add(new ChartArea());

                chart.Series.Add("Data");
                chart.Series[0].ChartType = SeriesChartType.Line;
                chart.Series[0].BorderWidth = 3;
                chart.ChartAreas[0].AxisX.Title = "Game Number";
                chart.ChartAreas[0].AxisY.Title = "Metric";
                chart.Series[0].ChartType = SeriesChartType.Line;
                chart.Series[0].BorderWidth = 3;
            }
        }
        private void PlotGraph(string chartName, List<MatchData> data, Func<MatchData, double> metricSelector, string metricLabel)
        {
            // Choose the correct chart based on the name
            var chart = chartName == "Ranked" ? chartRanked : chartNormal;

            // Clear existing data
            chart.Series.Clear();
            var series = new Series(metricLabel)
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3
            };

            // Add points to the series
            for (int i = 0; i < data.Count; i++)
            {
                double value = metricSelector(data[i]);
                series.Points.AddXY(i + 1, value);
            }

            // Customize the chart appearance
            chart.Series.Add(series);
            chart.Titles.Clear();
            chart.Titles.Add($"{chartName} Games - {metricLabel}");
            chart.ChartAreas[0].AxisX.Title = "Game Number";
            chart.ChartAreas[0].AxisY.Title = metricLabel;

            lblStatus.Text = $"Displaying {metricLabel} for {chartName} games";
        }
        private bool IsDataAvailable()
        {
            return rankedMatches != null && normalMatches != null
                   && rankedMatches.Any() && normalMatches.Any();
        }
        private void ResetGraphs()
        {
            foreach (var chart in new[] { chartRanked, chartNormal })
            {
                chart.Series.Clear();
                chart.Titles.Clear();
            }
        }
        #endregion

        #region Button Clicks
        private void btnFetchData_Click(object sender, EventArgs e)
        {
            ResetGraphs();
            lblStatus.Text = "Fetching data...";
            lblStatus.Refresh();

            try
            {
                var apiKey = "RGAPI-d84e7864-cd2d-4c0e-acda-78007913e5c7";
                var service = new APIHandler(apiKey);
                var gameName = txtGameName.Text;
                var tagLine = txtTagLine.Text;
                var gameCount = int.TryParse(txtGameCount.Text, out int count) ? count : 50;
                var summoner = service.GetSummoner(gameName, tagLine, "na1");

                if (summoner == null)
                {
                    lblStatus.Text = "Summoner not found!";
                    return;
                }

                var matchIds = service.GetMatchIds(summoner.Puuid, gameCount);
                var matches = service.GetMatchDataList(summoner.Puuid, matchIds);

                var (ranked, normal) = service.CategorizeMatches(matches);
                rankedMatches = ranked;
                normalMatches = normal;

                PlotGraph("Ranked", rankedMatches, m => m.CalculateKDA(), "KDA");
                PlotGraph("Normal", normalMatches, m => m.CalculateKDA(), "KDA");

                DisplaySummary();

                lblStatus.Text = $"Data loaded! Ranked: {rankedMatches.Count}, Normal: {normalMatches.Count}";
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("403"))
                    lblStatus.Text = "Error: Invalid or expired API key.";
                else
                    lblStatus.Text = $"Error: {ex.Message}";
            }
        }
        private void btnKDA_Click(object sender, EventArgs e)
        {
            if (!IsDataAvailable())
            {
                lblStatus.Text = "No data to display!";
                return;
            }
            PlotGraph("Ranked", rankedMatches, m => m.CalculateKDA(), "KDA");
            PlotGraph("Normal", normalMatches, m => m.CalculateKDA(), "KDA");
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            if (!IsDataAvailable())
            {
                lblStatus.Text = "No data to display!";
                return;
            }
            PlotGraph("Ranked", rankedMatches, m => m.DamageDealt, "Damage");
            PlotGraph("Normal", normalMatches, m => m.DamageDealt, "Damage");
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            if (!IsDataAvailable())
            {
                lblStatus.Text = "No data to display!";
                return;
            }
            PlotGraph("Ranked", rankedMatches, m => m.CreepScore, "Creep Score");
            PlotGraph("Normal", normalMatches, m => m.CreepScore, "Creep Score");
        }
        private void btnVision_Click(object sender, EventArgs e)
        {
            if (!IsDataAvailable())
            {
                lblStatus.Text = "No data to display!";
                return;
            }
            PlotGraph("Ranked", rankedMatches, m => m.VisionScore, "Vision Score");
            PlotGraph("Normal", normalMatches, m => m.VisionScore, "Vision Score");
        }
        private void btnWins_Click(object sender, EventArgs e)
        {
            if (!IsDataAvailable())
            {
                lblStatus.Text = "No data to display!";
                return;
            }
            PlotGraph("Ranked", rankedMatches, m => m.Win? 1 : 0, "Wins");
            PlotGraph("Normal", normalMatches, m => m.Win? 1 : 0, "Wins");
        }

        #endregion
    }
}
