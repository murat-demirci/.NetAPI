using StateDesignPattern.Kisim2.StateContext;

namespace StateDesignPattern.Kisim2.State
{
    public abstract class MusicPlayerState
    {
        public abstract void PlayMusic(MusicPlayer context);
        public abstract void StopMusic(MusicPlayer context);
    }
}
