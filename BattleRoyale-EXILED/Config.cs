using System;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BattleRoyale_EXILED
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("The message to show to the player upon joining. {player} will replace with the players username.")]
        public string JoinMessage { get; set; } = "{player} has joined the server.";
        [Description("The message to show to the player when they leave. {player} will replace with the players username.")]
        public string LeaveMessage { get; set; } = "{player} has joined the server.";
        
        [Description("The message to show to all players when the round starts.")]
        public string RoundStartedMessage { get; set; } = "Get ready to fight!";
    }
}