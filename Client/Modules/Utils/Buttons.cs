using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiraiLibs.UI;
using UnityEngine;
using MelonLoader;

namespace Client.API
{
    class ButtonConfiguration : ClientAPI
    {
        public static QMNestedButton _menuButton;
        public static QMNestedButton _movement;
        public static QMNestedButton _exploit;

        public static QMToggleButton _Fly;
        public static QMNestedButton _base;


        public override void OnStart()
        {
            QuickMenu.prop_QuickMenu_0.GetComponent<BoxCollider>().size += new Vector3(
           QuickMenu.prop_QuickMenu_0.GetComponent<BoxCollider>().size.x / 2.75f,
           QuickMenu.prop_QuickMenu_0.GetComponent<BoxCollider>().size.y / 2.25f);

            _menuButton = new QMNestedButton("ShortcutMenu", 5, 3, "?? Client", "All thing for U", Color.white, Color.white);

            _exploit = new QMNestedButton(_menuButton, 2, 0, "Exploit", "Exploit Menu");

            _movement = new QMNestedButton(_menuButton, 1, 0, "Movement", "Movement Menu");

            _base = new QMNestedButton(_exploit, 0, 0, "Movement", "Movement Menu");

            new QMToggleButton(_movement, 1, 0, "Fly ON", delegate ()
            {
                GeneralUtils._Fly = true;
            }, "Fly OFF", delegate ()
            {
                GeneralUtils._Fly = false;

            }, "Set on/off your flying !", Color.cyan, Color.white).setToggleState(GeneralUtils._Fly);

        }
    }
}