namespace DesignPatterns.Creation.Singleton
{
    /// <summary>
    /// Example of singleton instance that always exists 
    /// </summary>
    public static class Utils
    {
        public static DateTime GetTime()
        {
            return new DateTime();
        }

        public static double GetPI()
        {
            return Math.PI;
        }
    }
}
