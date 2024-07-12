using Exiled.API.Enums;
using Exiled.API.Features;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass.Configs;
using UnityEngine.Assertions.Must;
using System;

namespace Ass
{
    public class Phallic : Plugin<Config, Translation>
    {
        public static Phallic Instance { get; private set; } = null!;

        public override string Name => "PhallicObject";
        public override string Author => "OneOwen";
        public override PluginPriority Priority => PluginPriority.Lower;
        public override Version Version { get; }= new (0, 0, 1);

        private Handlers.EventHandler handler = null!;

        public override void OnEnabled()
        {
            Instance = this;
            handler = new(Instance);
            handler.RegisterEvents();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            handler.UnregisterEvents();
            handler = null!;
            Instance = null!;
            base.OnDisabled();
        }
    }
}
