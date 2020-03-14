using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMini.Composition.Torso
{
    class AstronautTorso : TorsoBase // My class AstronautTorso is a Torsobase(inheritance)
    {
        public int NumberOfArms { get; set; }

        public override bool ChiseledAbs { get; set; }

        public override void Flex() //This is related to TorsoBase, override keyword
        {
            if(ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick abs!");
            }
            else if(HandType == HandType.XBuster)
            {
                Console.WriteLine("Welcome to the gun show. Pew Pew!");
            }
            else
            {
                Console.WriteLine("Weird flex, but ok.");
            }
        }
        public override void Breathe()
        {
            Console.WriteLine("Exhale, Inhale....");
        }
    }

}
