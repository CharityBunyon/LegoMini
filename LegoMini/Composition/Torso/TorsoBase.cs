using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMini.Composition.Torso
{
    abstract class TorsoBase //implicitly internal, abstract is a keyword- must define the behavior
    {
        public abstract bool ChiseledAbs { get; set; } // everything that inherits from me must have everything and have a getter
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }

        public abstract void Flex(); // You have to implement that looks like this... their has to be a specified method

        public virtual void Breathe() // keyword that means, has behavior defined, but can be changed if need different behavior
        {
            Console.WriteLine("Inhale, Exhale!");
        }
    }
}
