using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    class Flamingo : Bird
    {
        public double LegLength { get; set; }

        public Flamingo(string name, int age, double weight) : base(name, age, weight)
        {
            LegLength = 12.5;
        }

        public override string Stats()
        {
            return base.Stats() + $"LegLength:{LegLength}";
        }
    }
}
