using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerBaseLib;
using UnityEngine;
using VRC.SDKBase;
using MelonLoader;
using Client.API;

namespace Client.Modules
{
    class Say : ClientAPI
    {
        public override void OnStart()
        {
            Console.WriteLine("thisisloaded.somaybeidk");
        }
    }
}
