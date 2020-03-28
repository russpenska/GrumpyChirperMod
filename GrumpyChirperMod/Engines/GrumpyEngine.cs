using GrumpyChirperMod.Grumpiness;
using ICities;
using System;
using System.Linq;

namespace GrumpyChirperMod.Engines
{
    public class GrumpyEngine : IGrumpyEngine
    {
        private readonly Random _random;
        private static readonly string[] Names = new string[] 
        { 
            "Grumpy Bob", 
            "Dave The Grouch", 
            "Angry Rob",
            "Irritated Irene"
        };
        
        private static readonly string[] LoadingMessages = new string[] 
        { 
            "Don't you have anything better to do? #sigh", 
            "Oh good the mayor's back. #killmenow", 
            "Another beautiful day in the worst city ever!",
            "BREAKING: The mayor unveils plans to somehow make things even worse.",
            "Oh great. You're back. #getalife"
        };

        private static readonly string[] BuildingRelocationMessages = new string[]
        {
            "MAKE YOUR MIND UP!",
            "We have literally the worst mayor in the world. #indecisive",
            "Why can't we just build things in the right place to start with!?",
            "Just when the view was getting acceptable, someone goes and moves something.",
            "If you'd build enough medical buildings, you might be able to get something for that indecision."
        };

        private static readonly string[] Responses = new string[]
        {
            "EVERYONE PLEASE JUST BE QUIET",
            "{previousHandle} you're talking utter nonsense, please stop.",
            "Oh just give it a rest {previousHandle}. #tired",
            "{previousHandle} Funny, I don't remember asking for your opinion!",
            "{previousHandle} go back to school! Oh wait, no, the mayor still hasn't built enough :( #stupid"
        };

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
                    return LoadingMessages;

                case GrumpinessTrigger.BuildingRelocated:
                    return BuildingRelocationMessages;
                default:
                    return new string[] { };
            }
        }

        public string GetRandomName()
        {
            var index = _random.Next(0, Names.Length);
            return Names[index];
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
            var index = _random.Next(0, Responses.Length);
            var response = Responses[index];

            var previousHandle = "@" + message.senderName.Replace(" ", "");

            return response.Replace("{previousHandle}", previousHandle);

        }
    }
}
