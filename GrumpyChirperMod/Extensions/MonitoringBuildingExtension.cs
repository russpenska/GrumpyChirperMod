using GrumpyChirperMod.Messaging;
using ICities;
using System.Diagnostics;

namespace GrumpyChirperMod.Extensions
{
    public class MonitoringBuildingExtension : BuildingExtensionBase
    {
        private IChirperMessageSender _chirperMessageSender;

        public MonitoringBuildingExtension()
            : this(new ChirperMessageSender())
        {
        }

        public MonitoringBuildingExtension(IChirperMessageSender chirperMessageSender)
        {
            _chirperMessageSender = chirperMessageSender ?? throw new System.ArgumentNullException(nameof(chirperMessageSender));
        }

        public override void OnBuildingCreated(ushort id)
        {
            // can we look up the id and find out what 
            // kind of building this is?

            Trace.WriteLine($"[GrumpyChirperMod] A building was created with id: {id}");
            _chirperMessageSender.SendMessage("George & Russ", $"This message brought to you by ID {id}.");
            base.OnBuildingCreated(id);
        }

        public override void OnBuildingRelocated(ushort id)
        {
            Trace.WriteLine($"[GrumpyChirperMod] A building was relocated with id: {id}");
            base.OnBuildingRelocated(id);
        }
    }
}
