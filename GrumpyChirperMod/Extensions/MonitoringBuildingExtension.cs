using ICities;
using System.Diagnostics;

namespace GrumpyChirperMod.Extensions
{
    public class MonitoringBuildingExtension : BuildingExtensionBase
    {
        public MonitoringBuildingExtension()
        {
        }

        public override void OnBuildingCreated(ushort id)
        {
            Trace.WriteLine($"[GrumpyChirperMod] A building was created with id: {id}");
            base.OnBuildingCreated(id);
        }

        public override void OnBuildingRelocated(ushort id)
        {
            Trace.WriteLine($"[GrumpyChirperMod] A building was relocated with id: {id}");
            base.OnBuildingRelocated(id);
        }
    }
}
