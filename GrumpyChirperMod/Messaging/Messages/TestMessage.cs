namespace GrumpyChirperMod.Messaging.Messages
{
    class TestMessage : MessageBase
    {
        private readonly uint _senderId;

        public TestMessage(uint senderId)
        {
            _senderId = senderId;
        }

        public override uint GetSenderID() => _senderId;

        public override string GetSenderName() => "Russ & George";

        public override string GetText() => "WELL DONE YOU WROTE A MESSAGE. REAL CLEVER OF YOU. #give #up";
    }
}
