using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftOff
{
    public static class Utility
    {

        public static int Clamp(int value, int min, int max)
        {
            return Clamp(value, min, max);
        }
        public static float Clamp(float value, float min, float max)
        {
            if(min > max)
            {
                return value;
            }

            if(value < min)
            {
                return min;
            }

            if (value > max)
                return max;

            return value;
        }
    }
}
