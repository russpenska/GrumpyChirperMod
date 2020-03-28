using GrumpyChirperMod.Data;
using GrumpyChirperMod.Grumpiness;
using ICities;
using System;
using System.Linq;

namespace GrumpyChirperMod.Engines
{
    public class GrumpyEngine : IGrumpyEngine
    {
        private readonly Random _random;

        public GrumpyEngine(Random random)
        {
            _random = random ?? throw new ArgumentNullException(nameof(random));
        }

        public string GetRandomMessage(GrumpinessTrigger trigger)
        {
            string[] messages = GetMessagesFor(trigger);

            if (messages == null || !messages.Any())
            {
                return string.Empty;
            }

            var index = _random.Next(0, messages.Length);
            return messages[index];
        }

        private static string[] GetMessagesFor(GrumpinessTrigger trigger)
        {
            switch (trigger)
            {
                case GrumpinessTrigger.LevelLoaded:
                    return RandomStrings.LoadingMessages();

                case GrumpinessTrigger.BuildingRelocated:
                    return RandomStrings.BuildingRelocationMessages();
                default:
                    return new string[] { };
            }
        }

        public string GetRandomName()
        {
            var names = RandomStrings.Names();
            var index = _random.Next(0, names.Length);
            return names[index];
        }

        public string GetRandomName(string invalidName)
        {
            string name;
            do
            {
                name = GetRandomName();
            } while (name == invalidName);

            return name;
        }

        public string GetRandomResponse(IChirperMessage message)
        {
            var responses = RandomStrings.Responses();
            var index = _random.Next(0, responses.Length);
            var response = responses[index];

            var previousHandle = "@" + message.senderName.Replace(" ", "");

            return response.Replace("{previousHandle}", previousHandle);

        }
    }
}
