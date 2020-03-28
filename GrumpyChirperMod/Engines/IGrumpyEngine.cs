using ICities;

namespace GrumpyChirperMod.Engines
{
    public interface IGrumpyEngine
    {
        /// <summary>
        /// Gets a random name.
        /// </summary>
        /// <returns>A random name</returns>
        string GetRandomName();
        /// <summary>
        /// Gets a random name that is different from the one passed in.
        /// </summary>
        /// <param name="invalidName">The name that should not be returned.</param>
        /// <returns>A random name</returns>
        string GetRandomName(string invalidName);
        /// <summary>
        /// Gets a random message.
        /// </summary>
        /// <param name="trigger">The trigger for this request, specifying the type of message to return.</param>
        /// <returns>A random message</returns>
        string GetRandomMessage(Grumpiness.GrumpinessTrigger trigger);
        /// <summary>
        /// Gets a random response to a Chirp. 
        /// </summary>
        /// <param name="message">The message to respond to.</param>
        /// <returns>A random response</returns>
        string GetRandomResponse(IChirperMessage message);
    }
}
