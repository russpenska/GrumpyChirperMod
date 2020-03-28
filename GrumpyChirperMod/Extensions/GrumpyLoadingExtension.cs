using GrumpyChirperMod.Engines;
using GrumpyChirperMod.Grumpiness;
using GrumpyChirperMod.Messaging;
using ICities;
using System;

namespace GrumpyChirperMod.Extensions
{
    public class GrumpyLoadingExtension : ILoadingExtension
    {
        private IChirperMessageSender _chirperMessageSender;
        private readonly IGrumpyEngine _grumpyEngine;

        public GrumpyLoadingExtension()
            : this(
                  new ChirperMessageSender(),
                  new GrumpyEngine(new Random((int)DateTime.UtcNow.Ticks)))
        {
        }

        public GrumpyLoadingExtension(
            IChirperMessageSender chirperMessageSender,
            IGrumpyEngine grumpyEngine)
        {
            _chirperMessageSender = chirperMessageSender ?? throw new ArgumentNullException(nameof(chirperMessageSender));
            _grumpyEngine = grumpyEngine ?? throw new ArgumentNullException(nameof(grumpyEngine));
        }

        public void OnCreated(ILoading loading)
        {
        }

        public void OnLevelLoaded(LoadMode mode)
        {

            _chirperMessageSender.SendMessage(
                _grumpyEngine.GetRandomName(),
                _grumpyEngine.GetRandomMessage(GrumpinessTrigger.LevelLoaded));
        }

        public void OnLevelUnloading()
        {
        }

        public void OnReleased()
        {
        }
    }
}
