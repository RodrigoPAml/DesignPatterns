using DesignPatterns.Behavioral.State.Context;
using DesignPatterns.Behavioral.State.Interface;

namespace DesignPatterns.Behavioral.State.States
{
    // Concrete state class
    class PlayingState : IState
    {
        public void Play(AudioPlayer player)
        {
            Console.WriteLine("Already playing.");
        }

        public void Pause(AudioPlayer player)
        {
            Console.WriteLine("Pausing the audio.");
            player.SetState(new PausedState());
        }

        public void Stop(AudioPlayer player)
        {
            Console.WriteLine("Stopping the audio.");
            player.SetState(new StoppedState());
        }
    }
}
