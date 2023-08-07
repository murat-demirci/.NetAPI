using StateDesignPattern.Kisim2.State;
using StateDesignPattern.Kisim2.StateContext;

namespace StateDesignPattern.Kisim2.ConcreteState
{
    public class Play : MusicPlayerState
    {
        public override void PlayMusic(MusicPlayer context) => Console.WriteLine("Muzik Zaten Caliyor");

        public override void StopMusic(MusicPlayer context)
        {
            Console.WriteLine("Muzik Duraklatildi");
            context.SetStop();
        }
    }
}
