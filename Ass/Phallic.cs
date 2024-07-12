using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    public class Phallic : Plugin<config, translation>
    {
        public static Phallic Instance { get; private set; } = null!;

        public override string Name => "PhallicObject";
        public override string Author => "OneOwen";
        public override PluginPriority => PluginPriority.Lower;
    }
}
