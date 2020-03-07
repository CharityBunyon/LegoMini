using System;

namespace LegoMini
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("Space Person", "Janitor");

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
