namespace GrumpyChirperMod.Messaging
{
    public interface IChirperMessageSender
    {
        void SendMessage(string from, string message);
    }
}
