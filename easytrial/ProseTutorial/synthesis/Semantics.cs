using System;
using System.Text.RegularExpressions;

namespace ProseTutorial
{
    public static class Semantics
    {
        public static int? Plus(int v, int k)
        {
            return v + k;
        }

        public static int? Minus(int v, int k)
        {
            return v - k;
        }
    }
}