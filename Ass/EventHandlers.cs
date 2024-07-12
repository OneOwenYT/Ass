using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ass.Handlers
{
    public class EventHandler
    {
        private readonly Phallic Phallic;
        public EventHandler(Phallic plugin) 
        {
            this.Phallic = plugin;
        }
        public void RegisterEvents()
        {
            Log.Debug("Doing Events");

            Exiled.Events.Handlers.Player.Verified += OnVerified;
        }
        public void UnregisterEvents()
        {
            Log.Debug("Doing Events");

            Exiled.Events.Handlers.Player.Verified -= OnVerified;
        }
        private void OnVerified(VerifiedEventArgs ev)
        {
            Log.Debug($"Verified: {ev.Player.Nickname}");
            ev.Player.Broadcast(5, $"Welcome to hell {ev.Player.Nickname}");
        }
    }
}
