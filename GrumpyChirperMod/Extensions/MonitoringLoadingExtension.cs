using GrumpyChirperMod.Engines;
using GrumpyChirperMod.Messaging;
using ICities;
using System.Diagnostics;

namespace GrumpyChirperMod.Extensions
{
    public class MonitoringLoadingExtension : ILoadingExtension
    {
        private IChirperMessageSender _chirperMessageSender;
        private readonly IGrumpyEngine _grumpyEngine;

        public MonitoringLoadingExtension()
            : this(
                  new ChirperMessageSender(),
                  new GrumpyEngine(new System.Random()))
        {
        }

        public MonitoringLoadingExtension(
            IChirperMessageSender chirperMessageSender,
            IGrumpyEngine grumpyEngine)
        {
            _chirperMessageSender = chirperMessageSender ?? throw new System.ArgumentNullException(nameof(chirperMessageSender));
            _grumpyEngine = grumpyEngine;
        }

        public void OnCreated(ILoading loading)
        {
            Trace.WriteLine("[GrumpyChirperMod] OnCreated");
        }

        public void OnLevelLoaded(LoadMode mode)
        {
            Trace.WriteLine("[GrumpyChirperMod] OnLevelLoaded - sending a message...");

            var randomName = _grumpyEngine.GetRandomName();
            var randomMessage = _grumpyEngine.GetRandomMessage();
            _chirperMessageSender.SendMessage(randomName, randomMessage);
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
