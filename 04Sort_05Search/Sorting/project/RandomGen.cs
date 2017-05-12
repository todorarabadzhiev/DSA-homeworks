using System;

namespace SortingHomework
{
    public static class RandomGen
    {
        private static Random random;

        private static void Init()
        {
            if (random == null)
            {
                random = new Random();
            }
        }

        public static int RandomInt(int min, int max)
        {
            Init();
            return random.Next(min, max);
        }
    }
}
