using DesignPatterns.Behavioral.State.Interface;
using DesignPatterns.Behavioral.State.States;

namespace DesignPatterns.Behavioral.State.Context
{
    // Context class
    class AudioPlayer
    {
        private IState state;

        public AudioPlayer()
        {
            // Initialize the player in the Stopped state
            state = new StoppedState();
        }

        public void SetState(IState newState)
        {
            state = newState;
        }

        public void Play()
        {
            state.Play(this);
        }

        public void Pause()
        {
            state.Pause(this);
        }

        public void Stop()
        {
            state.Stop(this);
        }
    }
}
