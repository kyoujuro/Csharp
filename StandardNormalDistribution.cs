using System;
using System.Collections.Generic;

namespace _A.Properties
{
    public class StandardNormalDistribution
    {
        static void Main(string[] args) {
            Dictionary<double, double> Zlist = new Dictionary<double, double>();
            Zlist.Add(0.00, 0.000);
            Zlist.Add(0.01, 0.040);
            Zlist.Add(0.02, 0.080);
            Zlist.Add(0.03, 0.120);
            Zlist.Add(0.04, 0.160);
            Zlist.Add(0.05, 0.199);
            Zlist.Add(0.06, 0.239);
            Zlist.Add(0.07, 0.279);
            Zlist.Add(0.08, 0.319);
            Zlist.Add(0.09, 0.359);
            Zlist.Add(0.10, 0.398);
            Zlist.Add(0.11, 0.438);
        }
    }
}
