using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
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

namespace Client
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
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
