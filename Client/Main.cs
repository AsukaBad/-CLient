using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using Photon.Realtime;
using RubyButtonAPI;
using MelonLoader;
using Client;
using Client.Modules;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRC.UI;
using System.Diagnostics;
using VRCSDK2;
using UnhollowerRuntimeLib;
using UnityEngine.Rendering.PostProcessing;
using HarmonyLib;
using Il2CppSystem.Reflection;
using System.Net.Http;
using System.IO;
using Microsoft.Win32;
using System.Net;
using Newtonsoft.Json;
using Client.API;
using System.Collections;

namespace Client
{
    public class Main : MelonMod
    {

        public static List<ClientAPI> Mods = new List<ClientAPI>();

        // we have to get our auth server. we don't have it now. or use github? idk how

        //private class VersionApi
        //{
        //  public string Version { get; set; }
        //  public string LoaderVersion { get; set; }
        //  public string DownloadURL { get; set; }
        //}

        // private string Version = "1.0.0";

        public override void OnApplicationStart()
        {


            //  using (WebClient wc = new WebClient())
            //  {
            //
            //      var obj = JsonConvert.DeserializeObject<VersionApi>(wc.DownloadString("WE DONT HAVE SERVER NOW"));
            //
            //      if (obj.Version == Version)
            //      {
            //          MelonLogger.Msg(ConsoleColor.Green, "You are running the latest version!");
            //      }
            //       else
            //      {
            //           MelonLogger.Msg(ConsoleColor.Yellow, $"You are running an outdated version! Latest Version: {obj.Version} | Your Version: {Version}. You can download the latest version from the https://discord.gg/4PE5TY5XJa");
            //      }
            //  }

            // add loading mod here
            Mods.Add(new ButtonConfiguration());
            Mods.Add(new JoinNotifier());
            Mods.Add(new Fly());
            Mods.Add(new Say());


            MelonCoroutines.Start(FindUI());


            foreach (ClientAPI mod in Mods)
            {
                ClientLogger.Log($"{mod.ModName} loaded!");
                mod.OnEarlierStart();
            }

            ClientLogger.Init();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n\n      ____  _     _  ____  __  _  _____ \n    / (__`| |__ | || ===||   | ||_   _|\n     ____)|____||_||____||_| __|  |_|  ");
            Console.WriteLine("\n\n\n?? Client loaded. thanks for monkey/blaze/keafy\n\n\n\n\n\n");
            Console.ResetColor();

            NetworkManagerHooks.OnJoin += NetworkManagerHooks_OnJoin;
            NetworkManagerHooks.OnLeave += NetworkManagerHooks_OnLeave;

        }

        private IEnumerator FindUI()
        {
            while (VRCUiManager.prop_VRCUiManager_0 == null) yield return null;
            VRCUI();
            yield break;
        }


        private void NetworkManagerHooks_OnJoin(VRC.Player player)
        {
            foreach (ClientAPI mod in Mods)
                mod.OnPlayerJoin(player);
        }

        private void NetworkManagerHooks_OnLeave(VRC.Player player)
        {
            foreach (ClientAPI mod in Mods)
                mod.OnPlayerLeave(player);
        }


        public void VRCUI()
        {
            foreach (ClientAPI mod in Mods)
                mod.OnStart();
        }


        public override void OnUpdate()
        {
            foreach (ClientAPI mod in Mods)
                mod.OnUpdate();
        }

        public override void OnLateUpdate()
        {
            foreach (ClientAPI mod in Mods)
                mod.OnLateUpdate();
        }

        public override void OnFixedUpdate()
        {
            foreach (ClientAPI mod in Mods)
                mod.OnFixedUpdate();
        }

        public override void OnGUI()
        {
            foreach (ClientAPI mod in Mods)
                mod.OnGUI();
        }

        public override void OnApplicationQuit()
        {
            foreach (ClientAPI mod in Mods)
                mod.OnQuit();
        }

    }
}
