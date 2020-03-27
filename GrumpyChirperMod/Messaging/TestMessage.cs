using System;

namespace GrumpyChirperMod.Messaging
{
    public class TestMessage : MessageBase
    {
        private readonly uint _senderId;
        private readonly string _name;
        private readonly string _text;

        public TestMessage(uint senderId, string name, string text)
        {
            _senderId = senderId;
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public override uint GetSenderID() => _senderId;
        public override string GetSenderName() => _name;
        public override string GetText() => _text;
    }
}