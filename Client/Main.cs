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

namespace Client
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("      ____  _     _  ____  __  _  _____ \n    / (__`| |__ | || ===||   | ||_   _|\n     ____)|____||_||____||_| __|  |_|  ");
            Console.ResetColor();
            Console.WriteLine("Only for me");

        }

    }
}
