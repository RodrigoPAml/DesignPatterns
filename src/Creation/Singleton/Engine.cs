namespace DesignPatterns.Creation.Singleton
{
    /// <summary>
    /// Example of singleton instance that exists only on demand
    /// </summary>
    public sealed class Engine
    {
        private static Engine Instance = null;

        public static Engine GetInstance()
        {
            if (Instance == null)
                Instance = new Engine();

            return Instance;
        }

        public Engine()
        {
            AllocResources();
        }

        public void Play()
        {
        }

        private void AllocResources()
        {
            // Alloc resources only when singleton created
        }
    }
}
