
using VRC;
using System;

namespace Client.API
{
    public static class NetworkManagerHooks
    {
        private static bool SeenFire;
        private static bool AFiredFirst;

        public static event Action<Player> OnJoin;
        public static event Action<Player> OnLeave;

        public static void EventHandlerA(Player player)
        {
            if (!SeenFire)
            {
                AFiredFirst = true;
                SeenFire = true;

                ClientLogger.Log("A fired first");
            }

            (AFiredFirst ? OnJoin : OnLeave)?.Invoke(player);
        }

        public static void EventHandlerB(Player player)
        {
            if (!SeenFire)
            {
                AFiredFirst = false;
                SeenFire = true;

                ClientLogger.Log("B fired first");
            }

            (AFiredFirst ? OnLeave : OnJoin)?.Invoke(player);
        }
    }
}
