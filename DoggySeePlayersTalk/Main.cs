using System;
using Exiled.API.Features;

namespace DoggySeePlayersTalk
{
    public class Main : Plugin<Config>
    {
        public override string Name => "DoggySeePlayersTalk";

        public override string Author => "LilNesquuik";

        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(5, 3, 0);

        internal static Main Instance { get; private set; }


        EventHandlers handlers = new EventHandlers();

        public override void OnEnabled()
        {
            Instance = this;

            Exiled.Events.Handlers.Player.VoiceChatting += handlers.OnVoiceChatting;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.VoiceChatting -= handlers.OnVoiceChatting;

            Instance = null;

            base.OnDisabled();
        }
    }
}
