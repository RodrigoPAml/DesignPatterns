using DesignPatterns.Behavioral.State.Context;
using DesignPatterns.Behavioral.State.Interface;

namespace DesignPatterns.Behavioral.State.States
{
    // Concrete state class
    class StoppedState : IState
    {
        public void Play(AudioPlayer player)
        {
            Console.WriteLine("Starting to play the audio.");
            player.SetState(new PlayingState());
        }

        public void Pause(AudioPlayer player)
        {
            Console.WriteLine("Cannot pause. Audio is stopped.");
        }

        public void Stop(AudioPlayer player)
        {
            Console.WriteLine("Already stopped.");
        }
    }
}
