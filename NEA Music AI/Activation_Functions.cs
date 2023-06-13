using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Music_AI
{
    public static class Activation_Functions
    {
        public static double Linear(double x) => x;
        public static double Absolute(double x) => Math.Abs(x);
        public static double ReLu(double x) => x < 0 ? 0:x;
        public static double Sigmoid(double x) => 1 / (1 + Math.Exp(-x));
    }
}
