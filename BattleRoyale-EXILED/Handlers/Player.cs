using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace BattleRoyale_EXILED.Handlers
{
    public class Player
    {
        public void OnLeft(LeftEventArgs av)
        {
            string message = BattleRoyale.instance.Config.LeaveMessage.Replace("{player}", av.Player.Nickname);
            Map.Broadcast(3, $"{av.Player} has left the server.");
        }
        public void OnJoin(JoinedEventArgs av)
        {
            string message = BattleRoyale.instance.Config.JoinMessage.Replace("{player}", av.Player.Nickname);
            Map.Broadcast(3, $"{av.Player} has joined the server.");
        }

        public void OnInteractDoor(InteractingDoorEventArgs av)
        {
            if (av.IsAllowed == false)
            {
                av.Player.Broadcast(5, "You cannot open this door!");
                av.Player.Kill(DamageTypes.Lure);
            }
        }
    }
}