using UnityEngine;
using Client.API;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using Il2CppSystem;
using MelonLoader;
using RubyButtonAPI;
using UnhollowerRuntimeLib;
using VRC.Core;
using VRC.SDKBase;

namespace Client.Modules
{
	public class VRCMinus : ClientAPI
	{
		public override string ModName => "VRC Minus";

		public override void OnStart()
		{
            GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/UserIconButton").SetActive(false);
            GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/VRCPlusMiniBanner/Image").SetActive(false);
            GameObject.Find("UserInterface/MenuContent/Screens/UserInfo/User Panel/Supporter").SetActive(false);
            GameObject.Find("UserInterface/MenuContent/Screens/UserInfo/AvatarImage/SupporterIcon").SetActive(false);
            GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/HeaderContainer/VRCPlusBanner/Panel").SetActive(false);
            GameObject.Find("UserInterface/MenuContent/Screens/UserInfo/User Panel/VRCPlusEarlyAdopter").SetActive(false);
            GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/VRC+PageTab").SetActive(false);
            GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/UserIconTab").SetActive(false);
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Favorite Avatar List/GetMoreFavorites").SetActive(false);
        }
	}
}