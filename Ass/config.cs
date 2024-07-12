using Exiled.API.Interfaces;

namespace Ass
{
    public class config : IConfig
    {
        public bool IsEnabled { get; set; }
        public bool Debug { get; set; }
    }
}