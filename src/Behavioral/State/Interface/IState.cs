using DesignPatterns.Behavioral.State.Context;

namespace DesignPatterns.Behavioral.State.Interface
{
    // State interface
    interface IState
    {
        void Play(AudioPlayer player);
        void Pause(AudioPlayer player);
        void Stop(AudioPlayer player);
    }
}
