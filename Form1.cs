using EndianTools;
using Server.SVO_CLI.SVOGames.Starhawk;
using SVO_Stats_Analyzer.Stats.Starhawk;
using System.Windows.Forms;

namespace SVO_Stats_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SVOStats files (*.bin)|*.bin|All files (*.*)|*.*",
                Title = "Select a SVO Stats Blob File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Starhawk":
                        {
                            switch (StatBlobTypeComboBox.SelectedItem.ToString())
                            {
                                case "Type1":
                                    {
                                        StarhawkStatBlobs.PlayerDetails playerDetails = StatsLoader.LoadPlayerDetailsStats(filePath);
                                        DisplayStarhawkPlayerDetailsStats(playerDetails);
                                    }
                                    break;
                                case "Type2":
                                    {
                                        StarhawkStatBlobs.PlayerSummary playerSummary = StatsLoader.LoadPlayerSummaryStats(filePath);
                                        DisplayStarhawkPlayerSummaryStats(playerSummary);
                                    }
                                    break;
                                case "Type6":
                                    {
                                        StarhawkStatBlobs.AwardsSummary awardsSummary = StatsLoader.LoadAwardsSummaryStats(filePath);
                                        DisplayStarhawkAwardsSummaryStats(awardsSummary);
                                    }
                                    break;
                            }
                        }
                        break;

                    case "Warhawk":
                        {
                            switch (StatBlobTypeComboBox.SelectedItem.ToString())
                            {
                                case "Type1":
                                    {
                                        //Unimplemented
                                    }
                                    break;

                            }
                        }
                        break;


                    case "Twisted Metal X":
                        {
                            switch (StatBlobTypeComboBox.SelectedItem.ToString())
                            {
                                case "Type1":
                                    {
                                        //Unimplemented
                                    }
                                    break;

                            }
                        }
                        break;

                    case "Resistance: Fall of Man":
                        {
                            switch (StatBlobTypeComboBox.SelectedItem.ToString())
                            {
                                case "Type1":
                                    {
                                        //Unimplemented
                                    }
                                    break;

                            }
                        }
                        break;
                }

            }
        }

        private void DisplayStarhawkPlayerDetailsStats(StarhawkStatBlobs.PlayerDetails playerDetails)
        {

            // Build a formatted string with each stat on a new line
            var statsText = $@"PlayerDetails:
Rating: {EndianUtils.ReverseInt(playerDetails.Rating)}
Exp: {EndianUtils.ReverseInt(playerDetails.Exp)}
Cash: {EndianUtils.ReverseInt(playerDetails.Cash)}
NumKills: {EndianUtils.ReverseInt(playerDetails.NumKills)}
NumDeaths: {EndianUtils.ReverseInt(playerDetails.NumDeaths)}
Suicides: {EndianUtils.ReverseInt(playerDetails.Suicides)}
TeamKills: {EndianUtils.ReverseInt(playerDetails.TeamKills)}
Headshots: {EndianUtils.ReverseInt(playerDetails.Headshots)}
Assists: {EndianUtils.ReverseInt(playerDetails.Assists)}
Score: {EndianUtils.ReverseInt(playerDetails.Score)}
Wins: {EndianUtils.ReverseInt(playerDetails.Wins)}
Losses: {EndianUtils.ReverseInt(playerDetails.Losses)}
KillPoints: {EndianUtils.ReverseInt(playerDetails.KillPoints)}
SupportPoints: {EndianUtils.ReverseInt(playerDetails.SupportPoints)}
FlagCaptures: {EndianUtils.ReverseInt(playerDetails.FlagCaptures)}
RiftCaptures: {EndianUtils.ReverseInt(playerDetails.RiftCaptures)}
BuildingsDestroyed: {EndianUtils.ReverseInt(playerDetails.BuildingsDestroyed)}
TimePlayed: {EndianUtils.ReverseInt(playerDetails.TimePlayed)}
TimeInCampaign: {EndianUtils.ReverseInt(playerDetails.TimeInCampaign)}
TimeInMultiplayer: {EndianUtils.ReverseInt(playerDetails.TimeInMultiplayer)}
TimeInCTF: {EndianUtils.ReverseInt(playerDetails.TimeInCTF)}
TimeInTDM: {EndianUtils.ReverseInt(playerDetails.TimeInTDM)}
TimeInDOM: {EndianUtils.ReverseInt(playerDetails.TimeInDOM)}
TimeInPROS: {TimeSpan.FromMinutes(EndianUtils.ReverseInt(playerDetails.TimeInPROS))}
SecondsAlive: {EndianUtils.ReverseInt(playerDetails.SecondsAlive)}
ComplaintCheating: {EndianUtils.ReverseInt(playerDetails.ComplaintCheating)}
ComplaintRude: {EndianUtils.ReverseInt(playerDetails.ComplaintRude)}
ComplaintUnsportsmanlike: {EndianUtils.ReverseInt(playerDetails.ComplaintUnsportsmanlike)}
PingSpikes: {EndianUtils.ReverseInt(playerDetails.PingSpikes)}
PingKill: {EndianUtils.ReverseInt(playerDetails.PingKill)}
PingMount: {EndianUtils.ReverseInt(playerDetails.PingMount)}
Draw: {EndianUtils.ReverseInt(playerDetails.Draw)}
CTFWin: {EndianUtils.ReverseInt(playerDetails.CTFWin)}
CTFLoss: {EndianUtils.ReverseInt(playerDetails.CTFLoss)}
CTFDraw: {EndianUtils.ReverseInt(playerDetails.CTFDraw)}
ProsWin: {EndianUtils.ReverseInt(playerDetails.ProsWin)}
ProsLoss: {EndianUtils.ReverseInt(playerDetails.ProsLoss)}
TDMWin: {EndianUtils.ReverseInt(playerDetails.TDMWin)}
TDMLoss: {EndianUtils.ReverseInt(playerDetails.TDMLoss)}
DOMWin: {EndianUtils.ReverseInt(playerDetails.DOMWin)}
DOMLoss: {EndianUtils.ReverseInt(playerDetails.DOMLoss)}
NumIntStats_0: {EndianUtils.ReverseInt(playerDetails.NumIntStats_0)}";

            // Display the formatted stats in the RichTextBox
            richTextBox1.Text = statsText;
        }

        private void DisplayStarhawkPlayerSummaryStats(StarhawkStatBlobs.PlayerSummary playerSummary)
        {

            // Build a formatted string with each stat on a new line
            var statsText = $@"PlayerSummary:
Rating: {EndianUtils.ReverseInt(playerSummary.Rating)}
Exp: {EndianUtils.ReverseInt(playerSummary.Exp)}
Kills: {EndianUtils.ReverseInt(playerSummary.Kills)}
Deaths: {EndianUtils.ReverseInt(playerSummary.Deaths)}
Wins: {EndianUtils.ReverseInt(playerSummary.Wins)}
Losses: {EndianUtils.ReverseInt(playerSummary.Losses)}
CTFWins: {EndianUtils.ReverseInt(playerSummary.CTFWins)}
TDMWins: {EndianUtils.ReverseInt(playerSummary.TDMWins)}
DOMWins: {EndianUtils.ReverseInt(playerSummary.DOMWins)}
DMWins: {EndianUtils.ReverseInt(playerSummary.DMWins)}
PRSWins: {EndianUtils.ReverseInt(playerSummary.PRSWins)}
BnBPartsPlaced: {EndianUtils.ReverseInt(playerSummary.BnBPartsPlaced)}
WheelmanAwards: {EndianUtils.ReverseInt(playerSummary.WheelmanAwards)}
DogfighterAwards: {EndianUtils.ReverseInt(playerSummary.DogfighterAwards)}
AntiAirAwards: {EndianUtils.ReverseInt(playerSummary.AntiAirAwards)}
RepairmanAwards: {EndianUtils.ReverseInt(playerSummary.RepairmanAwards)}
MechanicalArmyAwards: {EndianUtils.ReverseInt(playerSummary.MechanicalArmyAwards)}
UpCloseAwards: {EndianUtils.ReverseInt(playerSummary.UpCloseAwards)}
JeepDriverKillAssists: {EndianUtils.ReverseInt(playerSummary.JeepDriverKillAssists)}
StarhawksDestroyedDogFighting: {EndianUtils.ReverseInt(playerSummary.StarhawksDestroyedDogFighting)}
StarhawksDestroyedFromGround: {EndianUtils.ReverseInt(playerSummary.StarhawksDestroyedFromGround)}
VehicleRepairs: {EndianUtils.ReverseInt(playerSummary.VehicleRepairs)}
AutoTurretKills: {EndianUtils.ReverseInt(playerSummary.AutoTurretKills)}
MeleeKills: {EndianUtils.ReverseInt(playerSummary.MeleeKills)}
NumIntStats: {EndianUtils.ReverseInt(playerSummary.NumIntStats)}
";

            // Display the formatted stats in the RichTextBox
            richTextBox1.Text = statsText;
        }

        private void DisplayStarhawkAwardsSummaryStats(StarhawkStatBlobs.AwardsSummary awardsSummary)
        {

            // Build a formatted string with each stat on a new line
            var statsText = $@"AwardsSummary:
TotalAwardsEarnedPoints: {EndianUtils.ReverseInt(awardsSummary.TotalAwardsEarnedPoints)}
NumIntStats: {EndianUtils.ReverseInt(awardsSummary.NumIntStats)}
";

            // Display the formatted stats in the RichTextBox
            richTextBox1.Text = statsText;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StatBlobTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
