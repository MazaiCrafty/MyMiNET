using MiNET.Plugins;
using log4net;
using MiNET.Plugins.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePlugin
{
    [Plugin(PluginName = "EnableDisableExample", Description = "Example Plugin", PluginVersion = "1.2", Author = "_ICE_")]
    public class Main : Plugin
    {
        protected override void OnEnable()
        {
            base.OnEnable(); 
            Console.Write("[ExamplePlugin] Enable!!");
        }

        [Command(Command = "hello", Permission = "User")]
        public void Hello(Player sender)
        {
            sender.SendMessage("Welcome!!", MessageType.Raw);
        }

        [Command(Command = "good", Permission = "OP")]
        public void Good(Player sender)
        {
            sender.SendMessage("Good!!", MessageType.Raw);
        }

        protected override void OnDisabe()
        {
            base.OnDisabe();
            Console.Write("[ExamplePlugin] Disable!!");
        }
    }
}