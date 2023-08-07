using StateDesignPattern.Kisim2.ConcreteState;
using StateDesignPattern.Kisim2.State;

namespace StateDesignPattern.Kisim2.StateContext
{
    public class MusicPlayer
    {
        MusicPlayerState state;
        MusicPlayerState play;
        MusicPlayerState stop;

        public MusicPlayer()
        {
            play = new Play();
            stop = new Stop();
            state = play;
        }

        public void SetPlay() => state = play;
        public void SetStop() => state = stop;

        public void Play() => state.PlayMusic(this);
        public void Stop() => state.StopMusic(this);
    }
}
