using Exiled.API.Interfaces;

namespace Ass.Configs
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; }
        public bool Debug { get; set; }
    }
}