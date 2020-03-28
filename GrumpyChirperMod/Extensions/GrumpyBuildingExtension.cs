using GrumpyChirperMod.Engines;
using GrumpyChirperMod.Grumpiness;
using GrumpyChirperMod.Messaging;
using ICities;
using System;
using System.Diagnostics;

namespace GrumpyChirperMod.Extensions
{
    public class GrumpyBuildingExtension : BuildingExtensionBase
    {
        private IChirperMessageSender _chirperMessageSender;
        private readonly IGrumpyEngine _grumpyEngine;

        public GrumpyBuildingExtension()
            : this(
                  new ChirperMessageSender(),
                  new GrumpyEngine(new Random((int)DateTime.UtcNow.Ticks)))
        {
        }

        public GrumpyBuildingExtension(
            IChirperMessageSender chirperMessageSender,
            IGrumpyEngine grumpyEngine)
        {
            _chirperMessageSender = chirperMessageSender ?? throw new System.ArgumentNullException(nameof(chirperMessageSender));
            _grumpyEngine = grumpyEngine ?? throw new ArgumentNullException(nameof(grumpyEngine));
        }

        public override void OnBuildingCreated(ushort id)
        {
            // can we look up the id and find out what 
            // kind of building this is?

            //Trace.WriteLine($"[GrumpyChirperMod] A building was created with id: {id}");
            //_chirperMessageSender.SendMessage("George & Russ", $"Building types for id {id}:");
            base.OnBuildingCreated(id);
        }

        public override void OnBuildingRelocated(ushort id)
        {
            _chirperMessageSender.SendMessage(
                _grumpyEngine.GetRandomName(), 
                _grumpyEngine.GetRandomMessage(GrumpinessTrigger.BuildingRelocated));

            base.OnBuildingRelocated(id);
        }

        public override void OnCreated(IBuilding building)
        {
            Trace.WriteLine($"[GrumpyChirperMod] A building was created!");

            // _chirperMessageSender.SendMessage("George & Russ", $"A building was created!");
            base.OnCreated(building);
        }
    }
}
