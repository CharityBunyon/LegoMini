using System;
using LegoMini.Composition.Heads;
using LegoMini.Composition.Legs;
using LegoMini.Composition.Torso;

namespace LegoMini
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new AstronautHead
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            var torso = new AstronautTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                NumberOfArms = 3,
                Shirted = true
            };

            var astronaut = new Astronaut("Space Person", "Janitor", head, torso, legs);

            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today);
            casper.Friendly = true;

            // object initializer- same as above
            //var casper = new Ghost("Casper", DateTime.Today);
            //{
            //    Friendly = true,
            //}

            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();
        }
    }
}
