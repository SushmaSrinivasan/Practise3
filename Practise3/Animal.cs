using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public abstract void DoSound();
     //14. All new attributes of Animal to be added in this Animal class

        public virtual string stats()
        {
            return $"Name: {Name}, Age:{Age}, Weight:{Weight}";
        }
    }
}
