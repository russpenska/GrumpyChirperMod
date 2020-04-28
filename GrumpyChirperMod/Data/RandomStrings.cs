namespace GrumpyChirperMod.Data
{
    public class RandomStrings
    {
        public static string[] Names() => new string[]
        {
            "Grumpy Bob",
            "Dave The Grouch",
            "Angry Rob",
            "Irritated Irene",
            "Elon Musk",
            "Sulky Sally",
            "Simon The Unimpressed",
            "Whiney Wesley",
            "Drunk Steve",
            "Old Man Bob",
            "Mabel The Miserable",
            "Pensioner Penny",
            "Mandy Malicious",
            "Drunk Dave",
            "Debbie Downer"
        };

        public static string[] LoadingMessages() => new string[]
        {
            "Don't you have anything better to do? #sigh",
            "Oh good the mayor's back. #giveup",
            "Another beautiful day in the worst city ever!",
            "BREAKING: The mayor unveils plans to somehow make things even worse.",
            "Oh great. You're back. #getalife",
            "Looks like the mayor is back again from his professional golfing career!",
            "Brb, I'm starting a betting site on how much further in debt we'll go by the end of the day"
        };

        public static string[] BuildingRelocationMessages() => new string[]
        {
            "MAKE YOUR MIND UP!",
            "We have literally the worst mayor in the world. #indecisive",
            "Why can't we just build things in the right place to start with!?",
            "Just when the view was getting acceptable, someone goes and moves something.",
            "If you'd build enough medical buildings, you might be able to get something for that indecision.",
            "If you don't like the change you can move to another city! #MakeOurCityGreatAgain #MyMayor",
            "New drinking game, take a shot everytime the mayor can't make their mind up #dead"
        };

        public static string[] Responses() => new string[]
        {
            "EVERYONE PLEASE JUST BE QUIET",
            "{previousHandle} you're talking utter nonsense, please stop.",
            "Oh just give it a rest {previousHandle}. #tired",
            "{previousHandle} Funny, I don't remember asking for your opinion!",
            "{previousHandle} go back to school! Oh wait, no, the mayor still hasn't built enough :( #stupid",
            "This is probably the most coheret thing this office has ever said, and it's still nonsense!"
        };
    }
}
