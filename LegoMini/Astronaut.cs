using LegoMini.Composition.Heads;
using LegoMini.Composition.Legs;
using LegoMini.Composition.Torso;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMini
{
    enum Location
    {
        Earth,
        Space,
        SpaceStation
    }

    class Astronaut
    {
        //Public property
        public Location Location { get; set; }
        //Expression Bodied Property
        public bool SuitedUp => true;
        //Read-Only Property
        public string Name { get; }
        //Public property with a private setter
        public string Job { get; private set; }
        public int OxygenLevel { get; set; }
        //made a constructor(assesbility mod, name, params)- they need to have the same name as the class


        public AstronautTorso Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public AstronautHead Head { get; set; }


        public Astronaut(string name, string job, AstronautHead head, AstronautTorso torso, AstronautLegs legs)
        {
            Name = name;
            Job = job;

            Head = head;
            Torso = torso;
            Legs = legs;
        }
        //First way to set the setter to private or make another method... has to be done inside of the class
        //public void Promote()
        //{
        //    Job = "Commander of Janitors";
        //}

        //Method(behavior)
        public void DoYourJob()
        {
            Console.WriteLine($"Doing all my {Job} duties...");
            Legs.Walk(15);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(10);
        }
    }
}
