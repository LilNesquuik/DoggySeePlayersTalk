using Exiled.Events.EventArgs;
using UnityEngine;
using Exiled.API.Features;

namespace DoggySeePlayersTalk
{
    internal class EventHandlers
    {
        public void OnVoiceChatting(VoiceChattingEventArgs ev)
        {
            if (ev.Player.IsScp)
                return;

            ev.Player.ReferenceHub.scp939visionController.MakeNoise(Main.Instance.Config.SoundDistance);
        }
    }
}
