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



namespace Client
{
    public class Main : MelonMod
    {
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


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("      ____  _     _  ____  __  _  _____ \n    / (__`| |__ | || ===||   | ||_   _|\n     ____)|____||_||____||_| __|  |_|  ");
            Console.ResetColor();

            // why ClassInjector makes Error ???? "System.NullReferenceException:"
            ClassInjector.RegisterTypeInIl2Cpp<Say>();
            ClassInjector.RegisterTypeInIl2Cpp<Fly>();
            // I want to separate cs for each function. keafy......

            Console.WriteLine("Client Loaded");

        }

    }
}
