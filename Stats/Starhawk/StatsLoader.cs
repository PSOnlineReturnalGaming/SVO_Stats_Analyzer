using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.SVO_CLI.SVOGames.Starhawk;

namespace SVO_Stats_Analyzer.Stats.Starhawk
{
    public class StatsLoader
    {
        #region LoadPlayerDetailsStats
        public static StarhawkStatBlobs.PlayerDetails LoadPlayerDetailsStats(string filePath)
        {
            StarhawkStatBlobs.PlayerDetails playerDetails = new StarhawkStatBlobs.PlayerDetails();

            int version;
            int type;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {

                version = reader.ReadInt32();
                type = reader.ReadInt32();

                //42 stat vars
                playerDetails.Rating = reader.ReadInt32();
                playerDetails.Exp = reader.ReadInt32();
                playerDetails.Cash = reader.ReadInt32();
                playerDetails.NumKills = reader.ReadInt32();
                playerDetails.NumDeaths = reader.ReadInt32();
                playerDetails.Suicides = reader.ReadInt32();
                playerDetails.TeamKills = reader.ReadInt32();
                playerDetails.Headshots = reader.ReadInt32();
                playerDetails.Assists = reader.ReadInt32();
                playerDetails.Score = reader.ReadInt32();
                playerDetails.Wins = reader.ReadInt32();
                playerDetails.Losses = reader.ReadInt32();
                playerDetails.KillPoints = reader.ReadInt32();
                playerDetails.SupportPoints = reader.ReadInt32();
                playerDetails.FlagCaptures = reader.ReadInt32();
                playerDetails.RiftCaptures = reader.ReadInt32();
                playerDetails.BuildingsDestroyed = reader.ReadInt32();
                playerDetails.TimePlayed = reader.ReadInt32();
                playerDetails.TimeInCampaign = reader.ReadInt32();
                playerDetails.TimeInMultiplayer = reader.ReadInt32();
                playerDetails.TimeInCTF = reader.ReadInt32();
                playerDetails.TimeInTDM = reader.ReadInt32();
                playerDetails.TimeInDOM = reader.ReadInt32();
                playerDetails.TimeInPROS = reader.ReadInt32();
                playerDetails.SecondsAlive = reader.ReadInt32();
                playerDetails.ComplaintCheating = reader.ReadInt32();
                playerDetails.ComplaintRude = reader.ReadInt32();
                playerDetails.ComplaintUnsportsmanlike = reader.ReadInt32();
                playerDetails.PingSpikes = reader.ReadInt32();
                playerDetails.PingKill = reader.ReadInt32();
                playerDetails.PingMount = reader.ReadInt32();
                playerDetails.Draw = reader.ReadInt32();
                playerDetails.CTFWin = reader.ReadInt32();
                playerDetails.CTFLoss = reader.ReadInt32();
                playerDetails.CTFDraw = reader.ReadInt32();
                playerDetails.ProsWin = reader.ReadInt32();
                playerDetails.ProsLoss = reader.ReadInt32();
                playerDetails.TDMWin = reader.ReadInt32();
                playerDetails.TDMLoss = reader.ReadInt32();
                playerDetails.DOMWin = reader.ReadInt32();
                playerDetails.DOMLoss = reader.ReadInt32();
                playerDetails.NumIntStats_0 = reader.ReadInt32();
            }

            return playerDetails;
        }
        #endregion

        #region LoadPlayerSummaryStats
        public static StarhawkStatBlobs.PlayerSummary LoadPlayerSummaryStats(string filePath)
        {
            StarhawkStatBlobs.PlayerSummary playerSummary = new StarhawkStatBlobs.PlayerSummary();

            int version;
            int type;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {

                version = reader.ReadInt32();
                type = reader.ReadInt32();

                //42 stat vars
                playerSummary.Rating = reader.ReadInt32();
                playerSummary.Exp = reader.ReadInt32();
                playerSummary.Kills = reader.ReadInt32();
                playerSummary.Deaths = reader.ReadInt32();
                playerSummary.Wins = reader.ReadInt32();
                playerSummary.Losses = reader.ReadInt32();
                playerSummary.CTFWins = reader.ReadInt32();
                playerSummary.TDMWins = reader.ReadInt32();
                playerSummary.DOMWins = reader.ReadInt32();
                playerSummary.PRSWins = reader.ReadInt32();
                playerSummary.BnBPartsPlaced = reader.ReadInt32();
                playerSummary.WheelmanAwards = reader.ReadInt32();
                playerSummary.DogfighterAwards = reader.ReadInt32();
                playerSummary.AntiAirAwards = reader.ReadInt32();
                playerSummary.RepairmanAwards = reader.ReadInt32();
                playerSummary.MechanicalArmyAwards = reader.ReadInt32();
                playerSummary.UpCloseAwards = reader.ReadInt32();
                playerSummary.JeepDriverKillAssists = reader.ReadInt32();
                playerSummary.StarhawksDestroyedDogFighting = reader.ReadInt32();
                playerSummary.StarhawksDestroyedFromGround = reader.ReadInt32();
                playerSummary.VehicleRepairs = reader.ReadInt32();
                playerSummary.AutoTurretKills = reader.ReadInt32();
                playerSummary.MeleeKills = reader.ReadInt32();
                playerSummary.NumIntStats = reader.ReadInt32();
            }

            return playerSummary;
        }
        #endregion


        //Type 6
        #region LoadAwardsSummaryStats
        public static StarhawkStatBlobs.AwardsSummary LoadAwardsSummaryStats(string filePath)
        {
            StarhawkStatBlobs.AwardsSummary awardsSummary = new StarhawkStatBlobs.AwardsSummary();

            int version;
            int type;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {

                version = reader.ReadInt32();
                type = reader.ReadInt32();

                awardsSummary.TotalAwardsEarnedPoints = reader.ReadInt32();
                awardsSummary.NumIntStats = reader.ReadInt32();
            }

            return awardsSummary;
        }
        #endregion
    }
}
