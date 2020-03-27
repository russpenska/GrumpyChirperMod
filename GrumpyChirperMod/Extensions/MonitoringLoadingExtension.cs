using GrumpyChirperMod.Messages;
using ICities;
using System.Diagnostics;

namespace GrumpyChirperMod.Extensions
{
    public class MonitoringLoadingExtension : ILoadingExtension
    {
        public void OnCreated(ILoading loading)
        {
            Trace.WriteLine("[GrumpyChirperMod] OnCreated");
        }

        public void OnLevelLoaded(LoadMode mode)
        {
            Trace.WriteLine("[GrumpyChirperMod] OnLevelLoaded - sending a message...");

            // this is a weird place to hook in
            // but it works for now

            //IGrumpyChirper chirper = new GrumpyChirper();
            //chirper.SendMessage("Name", "Message");

            var senderId = MessageManager.instance.GetRandomResidentID();
            var message = new TestMessage(senderId);
            MessageManager.instance.QueueMessage(message);
        }

        public void OnLevelUnloading()
        {
            Trace.WriteLine("[GrumpyChirperMod] OnLevelUnloading");
        }

        public void OnReleased()
        {

            Trace.WriteLine("[GrumpyChirperMod] OnReleased");
        }
    }
}
