namespace GrumpyChirperMod.Messaging
{
    public class ChirperMessageSender : IChirperMessageSender
    {
        public void SendMessage(string from, string text)
        {
            var senderId = MessageManager.instance.GetRandomResidentID();
            var message = new TestMessage(senderId, from, text);
            MessageManager.instance.QueueMessage(message);
        }
    }
}
