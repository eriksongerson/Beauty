using System;

namespace Beauty.Helpers
{
    public static class RandomHelper
    {
        private static readonly Random random = new Random();

        public static int getNumber()
        {
            lock (random)
            {
                return random.Next(1000, 10000);
            }
        }

    }
}
