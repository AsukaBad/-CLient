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
using Client.Modules;
using KiraiLibs.UI;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;

using System.Collections;
using System.Diagnostics;



namespace Client.Modules
{
    class Simples : ClientAPI
    {
        public override void OnStart()
        {
            new QMToggleButton(ButtonConfiguration._exploit, 0, 0, "AsukaDesync", delegate ()
            {
                GeneralUtils._AsukaDesync = true;
            }, "Desync ON", delegate ()
            {
                GeneralUtils._AsukaDesync = false;

            }, "Desync ON", Color.red, Color.white).setToggleState(GeneralUtils._Fly);



        }


        public override void OnUpdate()
        {
            if (GeneralUtils._AsukaDesync == true)
            {
                try
                {
                    Delay += Time.deltaTime;
                    if (Delay > 1f)
                    {
                        for (int i = 0; i < 420; i++)
                        {
                            byte[] bytes1 = new byte[] { 255 };
                            byte[] IDOut = BitConverter.GetBytes(PlayerExtensions.GetActorNumber(PlayerExtensions.LocalPlayer));
                            Buffer.BlockCopy(IDOut, 0, bytes1, 5, 4);
                            OpRaiseEvent(9, bytes1, new RaiseEventOptions
                            {
                                field_Public_ReceiverGroup_0 = ReceiverGroup.Others,
                                field_Public_EventCaching_0 = EventCaching.DoNotCache
                            }, default(SendOptions));
                        }
                        Delay = 0f;
                    }
                }
                catch { }

            }
        }

            public static void OpRaiseEvent(byte code, object customObject, RaiseEventOptions RaiseEventOptions, SendOptions sendOptions)
            {
                Il2CppSystem.Object customObject2 = Serialization.FromManagedToIL2CPP<Il2CppSystem.Object>(customObject);
                OpRaiseEvent(code, customObject2, RaiseEventOptions, sendOptions);
            }

            public static void OpRaiseEvent(byte code, Il2CppSystem.Object customObject, RaiseEventOptions RaiseEventOptions, SendOptions sendOptions)
            {
                PhotonNetwork.field_Public_Static_LoadBalancingClient_0.Method_Public_Virtual_New_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0(code, customObject, RaiseEventOptions, sendOptions);
            }

        public static float Delay;
    }
    
}
