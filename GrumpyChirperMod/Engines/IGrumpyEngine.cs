using ICities;

namespace GrumpyChirperMod.Engines
{
    public interface IGrumpyEngine
    {
        string GetRandomName();
        string GetRandomMessage(Grumpiness.GrumpinessTrigger trigger);
        string GetRandomResponse(IChirperMessage message);
    }
}
