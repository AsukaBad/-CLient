
using VRC;
using Client.API;

namespace Client.Modules
{
    public class JoinNotifier : ClientAPI
    {
        
        public override string ModName => "Join notifier";
        public override void OnStart()
        {
            NetworkManagerHooks.Initialize();
        }
        public override void OnPlayerJoin(Player player)
        {
            var playerName = player.prop_APIUser_0;
            ClientLogger.Log(System.ConsoleColor.Green,$"[{player?.prop_APIUser_0.displayName}] joined!  ->{player?.prop_APIUser_0.username}");

        }

        public override void OnPlayerLeave(Player player)
        {
            var playerName = player.prop_APIUser_0;
            ClientLogger.Log(System.ConsoleColor.Red,$"[{player?.prop_APIUser_0.displayName}] left!  ->{player?.prop_APIUser_0.username}");

        }
    }
}