using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.API;
using RubyButtonAPI;
using UnityEngine;
using MelonLoader;


namespace Client.Modules
{
    class ButtonConfiguration : ClientAPI
    {
        private QMNestedButton _menuButton;
        private QMNestedButton _movement;


        public override void OnStart()
        {
            QuickMenu.prop_QuickMenu_0.GetComponent<BoxCollider>().size += new Vector3(
           QuickMenu.prop_QuickMenu_0.GetComponent<BoxCollider>().size.x / 2.75f,
           QuickMenu.prop_QuickMenu_0.GetComponent<BoxCollider>().size.y / 2.25f);

            _menuButton = new QMNestedButton("ShortcutMenu", 5, 3, "", "Wings Client Menu", Color.white, Color.white);

            _movement = new QMNestedButton(_menuButton, 1, 0, "Movement", "Movement Menu");

        }
    }
}