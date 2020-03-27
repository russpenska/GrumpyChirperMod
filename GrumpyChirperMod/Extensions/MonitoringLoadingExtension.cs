using GrumpyChirperMod.Messaging;
using ICities;
using System.Diagnostics;

namespace GrumpyChirperMod.Extensions
{
    public class MonitoringLoadingExtension : ILoadingExtension
    {
        private IChirperMessageSender _chirperMessageSender;

        public MonitoringLoadingExtension()
            : this(new ChirperMessageSender())
        {
        }

        public MonitoringLoadingExtension(IChirperMessageSender chirperMessageSender)
        {
            _chirperMessageSender = chirperMessageSender ?? throw new System.ArgumentNullException(nameof(chirperMessageSender));
        }

        public void OnCreated(ILoading loading)
        {
            Trace.WriteLine("[GrumpyChirperMod] OnCreated");
        }

        public void OnLevelLoaded(LoadMode mode)
        {
            Trace.WriteLine("[GrumpyChirperMod] OnLevelLoaded - sending a message...");
            _chirperMessageSender.SendMessage("Grumpy Bob", "Oh great. You're back. #getalife");
        }

        public void OnLevelUnloading()
        {
            Trace.WriteLine("[GrumpyChirperMod] OnLevelUnloading");
        }

        public void OnReleased()
        {

            Trace.WriteLine("[GrumpyChirperMod] OnReleased");
        }
    }
}
