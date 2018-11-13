using System;

namespace StringExtensions.Benchmark
{
    internal class Url
    {
        internal static string Content(string v)
        {
            return "http://" + v;
        }

        internal static string Action(string v1, string v2, object p)
        {
            return "http://" + v1 + v2 + p.GetHashCode();
        }
    }
}