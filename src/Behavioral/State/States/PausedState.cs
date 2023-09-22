using DesignPatterns.Behavioral.State.Context;
using DesignPatterns.Behavioral.State.Interface;

namespace DesignPatterns.Behavioral.State.States
{
    // Concrete state class
    class PausedState : IState
    {
        public void Play(AudioPlayer player)
        {
            Console.WriteLine("Resuming the audio.");
            player.SetState(new PlayingState());
        }

        public void Pause(AudioPlayer player)
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop(AudioPlayer player)
        {
            Console.WriteLine("Stopping the audio.");
            player.SetState(new StoppedState());
        }
    }
}
