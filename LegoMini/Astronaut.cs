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

        //Read only property
        //public string Job {get;}

        //made a constructor(assesbility mod, name, params)- they need to have the same name as the class
        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
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
        }
    }
}
