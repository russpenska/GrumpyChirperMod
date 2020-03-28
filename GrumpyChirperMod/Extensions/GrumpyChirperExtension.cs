using GrumpyChirperMod.Engines;
using GrumpyChirperMod.Messaging;
using ICities;
using System;
using System.Diagnostics;

namespace GrumpyChirperMod.Extensions
{
    public class GrumpyChirperExtension : IChirperExtension
    {
        private readonly IChirperMessageSender _chirperMessageSender;
        private readonly IGrumpyEngine _grumpyEngine;
        private readonly Random _random;
        private readonly decimal _probabilityOfResponding;

        public GrumpyChirperExtension()
            :this(new ChirperMessageSender(),
                 new GrumpyEngine(new Random((int)DateTime.UtcNow.Ticks)),
                 new Random((int)DateTime.UtcNow.Ticks),
                 0.2m)
        {
        }

        public GrumpyChirperExtension(
            IChirperMessageSender chirperMessageSender,
            IGrumpyEngine grumpyEngine,
            Random random,
            decimal probabilityOfResponding)
        {
            _chirperMessageSender = chirperMessageSender ?? throw new ArgumentNullException(nameof(chirperMessageSender));
            _grumpyEngine = grumpyEngine ?? throw new ArgumentNullException(nameof(grumpyEngine));
            _random = random ?? throw new ArgumentNullException(nameof(random));
            _probabilityOfResponding = probabilityOfResponding;
        }

        public void OnCreated(IChirper chirper)
        {
        }

        public void OnMessagesUpdated()
        {
        }

        public void OnNewMessage(IChirperMessage message)
        {
            var shouldSend = _random.Next(0, 100) > (_probabilityOfResponding * 100);
            if (!shouldSend)
            {
                return;
            }

            _chirperMessageSender.SendMessage(
                _grumpyEngine.GetRandomName(message.senderName),
                _grumpyEngine.GetRandomResponse(message));
        }

        public void OnReleased()
        {
        }

        public void OnUpdate()
        {
        }
    }
}
