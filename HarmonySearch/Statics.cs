using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySearch
{
    public static class Statics
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        //public static int getRandomInteger(int min, int max)
        //{
        //    lock (syncLock)
        //    {
        //        return random.Next(min, max);
        //    }
        //}
        public static double getRandomDouble(double min, double max)
        {
            lock (syncLock)
            {
                return random.NextDouble() * (max - min) + min;
            }
        }

        public static float getRandomFloat(float min, float max)
        {
            lock (syncLock)
            {
                return (float)random.NextDouble() * (max - min) + min;
            }
        }
    }
}
