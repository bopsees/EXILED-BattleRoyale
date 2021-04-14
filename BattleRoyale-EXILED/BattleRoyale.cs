using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace BattleRoyale_EXILED
{
    public class BattleRoyale : Plugin<Config>
    {
        private static readonly Lazy<BattleRoyale> LazyInstance = new Lazy<BattleRoyale>(() => new BattleRoyale());
        public static BattleRoyale instance => LazyInstance.Value;

        private Handlers.Player player;
        private Handlers.Server server;
        
        public override PluginPriority Priority { get; } = PluginPriority.Highest;

        private BattleRoyale()
        {
            
        }

        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            player = new Handlers.Player();
            server = new Handlers.Server();

            Server.WaitingForPlayers += server.OnWaitingForPlayers;
            Server.RoundStarted += server.OnRoundStart;

            Player.Left += player.OnLeft;
            Player.Joined += player.OnJoin;
            Player.InteractingDoor += player.OnInteractDoor;
        }

        public void UnregisterEvents()
        {
            Server.WaitingForPlayers -= server.OnWaitingForPlayers;
            Server.RoundStarted -= server.OnRoundStart;

            Player.Left -= player.OnLeft;
            Player.Joined -= player.OnJoin;
            Player.InteractingDoor -= player.OnInteractDoor;

            player = null;
            server = null;
        }
    }
}