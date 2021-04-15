using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace BattleRoyale_EXILED.Handlers
{
    public class Player
    {
        public void OnLeft(LeftEventArgs av)
        {
            string message = BattleRoyale.instance.Config.LeaveMessage.Replace("{player}", av.Player.Nickname);
            Map.Broadcast(3, message);
        }
        public void OnJoin(JoinedEventArgs av)
        {
            string message = BattleRoyale.instance.Config.JoinMessage.Replace("{player}", av.Player.DisplayNickname);
            Map.Broadcast(3, message);
        }
    }
}