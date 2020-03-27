using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrumpyChirperMod.Messaging
{
    public class ChirperMessageSender : IChirperMessageSender
    {
        public void SendMessage(string from, string message)
        {
            var senderId = MessageManager.instance.GetRandomResidentID();
            var message = new TestMessage(senderId);
            MessageManager.instance.QueueMessage(message);
        }
    }
}
