using System;
using System.Collections.Generic;

namespace _A.Properties
{
    public class StandardNormalDistribution
    {
        static void Main(string[] args) {
            Dictionary<double, double> Zlist = new Dictionary<double, double>();
            Zlist.Add(0.00, 0.000);
            Zlist.Add(0.01, 0.0040);
            Zlist.Add(0.02, 0.0080);
            Zlist.Add(0.03, 0.0120);
            Zlist.Add(0.04, 0.0160);
            Zlist.Add(0.05, 0.0199);
            Zlist.Add(0.06, 0.0239);
            Zlist.Add(0.07, 0.0279);
            Zlist.Add(0.08, 0.0319);
            Zlist.Add(0.09, 0.0359);
            Zlist.Add(0.10, 0.0398);
            Zlist.Add(0.11, 0.0438);
            Zlist.Add(0.12, 0.0478);
            Zlist.Add(0.13, 0.0517);
            Zlist.Add(0.14, 0.0557);
        }
    }
}
