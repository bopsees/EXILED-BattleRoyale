using Exiled.API.Features;

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
            Log.Info("[BATTLE ROYALE] - Game Starting");
            Map.Broadcast(5, BattleRoyale.instance.Config.RoundStartedMessage);
        }
    }
}