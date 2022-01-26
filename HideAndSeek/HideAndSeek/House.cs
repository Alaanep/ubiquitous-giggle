using System;
namespace HideAndSeek
{
    public static class House
    {
        /// <summary>
        /// Returns  the starting location for the player
        /// </summary>
        public static readonly Location Entry;

        /// <summary>
        /// Sets up the  house data structure
        /// </summary>
        static House()
        {
            Entry = new Location("Entry");
            var hallway = new Location("Hallway");
            var bathroom = new Location("Bathroom");
            var kitchen = new Location("Kitchen");
            var garage = new Location("Garage");
            var livingroom = new Location("Living Room");
            var landing = new Location("Landing");
            var masterBedroom = new Location("Master Bedroom");
            var masterbath = new Location("Master Bath");
            var secondBathroom = new Location("Second Bathroom");
            var nursery = new Location("Nursery");
            var pantry = new Location("Pantry");
            var kidsroom = new Location("Kids Room");
            var attic = new Location("Attic");

            Entry.AddExit(Direction.Out, garage);
            Entry.AddExit(Direction.East, hallway);
            hallway.AddExit(Direction.Northwest, kitchen);
            hallway.AddExit(Direction.North, bathroom);
            hallway.AddExit(Direction.South, livingroom);
            hallway.AddExit(Direction.Up, landing);
            landing.AddExit(Direction.Northwest, masterBedroom);
            masterBedroom.AddExit(Direction.East, masterbath);
            landing.AddExit(Direction.West, secondBathroom);
            landing.AddExit(Direction.Southwest, nursery);
            landing.AddExit(Direction.South, pantry);
            landing.AddExit(Direction.Southeast, kidsroom);
            landing.AddExit(Direction.Up, attic);


        }

    }
}
