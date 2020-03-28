using System;

namespace GrumpyChirperMod.Engines
{
    public class GrumpyEngine : IGrumpyEngine
    {
        private readonly Random _random;
        private static readonly string[] Names = new string[] 
        { 
            "Grumpy Bob", 
            "Dave The Grouch", 
            "Angry Rob" 
        };
        
        private static readonly string[] Messages = new string[] 
        { 
            "Don't you have anything better to do? #sigh", 
            "Oh good the mayor's back. #killmenow", 
            "Another beautiful day in the worst city ever!",
            "BREAKING: The mayor unveils plans to somehow make things even worse.",
            "Oh great. You're back. #getalife"
        };

        public GrumpyEngine(Random random)
        {
            _random = random ?? throw new ArgumentNullException(nameof(random));
        }

        public string GetRandomMessage()
        {
            var index = _random.Next(0, Messages.Length);
            return Messages[index];
        }

        public string GetRandomName()
        {
            var index = _random.Next(0, Names.Length);
            return Names[index];
        }
    }
}
