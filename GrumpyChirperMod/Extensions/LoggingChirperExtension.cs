using ICities;
using System.Diagnostics;

namespace GrumpyChirperMod.Extensions
{
    public class LoggingChirperExtension : IChirperExtension
    {
        public void OnCreated(IChirper chirper)
        {
        }

        public void OnMessagesUpdated()
        {
        }

        public void OnNewMessage(IChirperMessage message)
        {
            Trace.WriteLine($"Chirper message received from {message.senderName}: {message.text}.");
        }

        public void OnReleased()
        {
        }

        public void OnUpdate()
        {
        }
    }
}
