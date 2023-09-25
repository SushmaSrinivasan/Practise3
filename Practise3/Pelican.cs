using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    class Pelican : Bird
    {
        public new double WingSpan { get; set; }

        public Pelican(string name, int age, double weight) : base(name, age, weight)
        {
            WingSpan = 10.0;
        }
        public override string Stats()
        {
            return base.Stats() + $"WingSpan:{WingSpan}";
        }
    }
}
