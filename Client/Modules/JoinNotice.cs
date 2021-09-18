using VRC;
using Client.API;

namespace Client.Modules
{
    public class JoinNotifier : ClientAPI
    {
        public override string ModName => "Join notifier";

        public override void OnPlayerJoin(Player player)
        {
            string playerName = player.gameObject.GetComponent<VRCPlayer>().ToString();
            ClientLogger.Log($"{playerName} joined room!");
        }

        public override void OnPlayerLeave(Player player)
        {
            string playerName = player.gameObject.GetComponent<VRCPlayer>().ToString();
            ClientLogger.Log($"{playerName} leaved room!");
        }
    }
}