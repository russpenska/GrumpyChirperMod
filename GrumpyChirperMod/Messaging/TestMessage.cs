namespace GrumpyChirperMod.Messaging
{
    public class TestMessage : MessageBase
    {
        public TestMessage(string name, string message)
        {
            // todo set _senderId
        }

        public override uint GetSenderID()
        {
            return base.GetSenderID();
        }

        public override string GetSenderName()
        {
            return base.GetSenderName();
        }

        public override string GetText()
        {
            return base.GetText();
        }
    }
}