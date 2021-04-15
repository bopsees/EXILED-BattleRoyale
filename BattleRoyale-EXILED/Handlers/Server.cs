using System.Collections.Generic;
using System.Diagnostics;
using Exiled.API.Features;
using ArithFeather.Points;
using ArithFeather.Points.DataTypes;

namespace BattleRoyale_EXILED.Handlers
{
    public class Server
    {
        public void OnWaitingForPlayers()
        {
            Log.Info("[BATTLE ROYALE] - Waiting For Players");
        }

        public void OnRoundStart()
        {
            PointList pList = ArithFeather.Points.Points.GetPointList("gun");
            List<FixedPoint> fList = pList.FixedPoints;
            for (int i = 0; i < fList.Count; i++)
            {
                Log.Info(fList[i]);
            }
            Round.IsLocked = true;
            foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
            {
                player.AddItem(ItemType.KeycardO5);
                player.Role = RoleType.ClassD;
                Map.Broadcast(5, BattleRoyale.instance.Config.RoundStartedMessage);
            }
        }
    }
}