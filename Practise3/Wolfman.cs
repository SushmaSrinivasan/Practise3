using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight):base(name, age, weight) { }

        public string Talk()
        {
            return $"{Name} says, I am a Wolfman";
        }
    }
}
