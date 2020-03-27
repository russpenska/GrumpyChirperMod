namespace GrumpyChirperMod.Messaging
{
    public class TestMessage : MessageBase
    {
        private readonly uint _senderId;
        private readonly string _name;
        private readonly string _message;

        public TestMessage(uint senderId, string name, string message)
        {
            _senderId = senderId;
            _name = name ?? throw new System.ArgumentNullException(nameof(name));
            _message = message ?? throw new System.ArgumentNullException(nameof(message));
        }

        public override uint GetSenderID() => _senderId;
        public override string GetSenderName() => _name;
        public override string GetText() => _message;
    }
}