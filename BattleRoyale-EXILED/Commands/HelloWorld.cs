using System;
using CommandSystem;
using RemoteAdmin;

namespace BattleRoyale_EXILED.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class HelloWorld : ICommand
    {
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                response = $"Hello {player.Nickname}!";
                return false;
            }
            else
            {
                response = "World";
                return true;
            }
        }

        public string Command { get; } = "hello";
        public string[] Aliases { get; } = {"hey"};
        public string Description { get; } = "Responds with hello!";
    }
}