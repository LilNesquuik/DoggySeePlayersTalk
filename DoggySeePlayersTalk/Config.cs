using System.ComponentModel;
using Exiled.API.Interfaces;

namespace DoggySeePlayersTalk
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("The distance at which the SCP-939 can hear you when you speak.")]
        public float SoundDistance { get; set; } = 7;
    }
}