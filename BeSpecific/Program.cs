using System;


namespace BeSpecific
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bicycles, woodworking, music, and video games. These are a few of my favorite things.  How about you?");
            var redBike = new Bike("red");
            redBike.HasPedals = true;
            redBike.TakesPractice = true;
            redBike.RequiresCoordination = true;
            redBike.isCreative = false;
            redBike.BikeColor();
            redBike.Ride();
            redBike.Practice();
            redBike.BePatient();
           

            var mountainBike = new Bike("blue");
            mountainBike.HasPedals = true;
            mountainBike.TakesPractice = true;
            mountainBike.RequiresCoordination = true;
            mountainBike.isCreative = false;
            mountainBike.BikeColor();
            mountainBike.Ride();
            mountainBike.Practice();
            mountainBike.BePatient();

            var roadBike = new Bike("maroon");
            roadBike.HasPedals = true;
            roadBike.TakesPractice = true;
            roadBike.RequiresCoordination = true;
            roadBike.isCreative = false;
            roadBike.BikeColor();
            roadBike.Ride();
            roadBike.Practice();
            roadBike.BePatient();


            Console.WriteLine("Do you like to woodwork?");
            var woodworker = new Woodwork();
            woodworker.isCreative = true;
            woodworker.TakesPractice = true;
            woodworker.RequiresCoordination = true;
            woodworker.NeedsPatience = true;
            woodworker.BePatient();
            woodworker.Practice();
            woodworker.Build();
            woodworker.UsePowerTools();

            var craftsman = new Woodwork();
            craftsman.isCreative = true;
            craftsman.TakesPractice = true;
            craftsman.RequiresCoordination = true;
            craftsman.NeedsPatience = true;
            craftsman.BePatient();
            craftsman.Practice();
            craftsman.Build();
            craftsman.UsePowerTools();

            var builder = new Woodwork();
            builder.isCreative = true;
            builder.TakesPractice = true;
            builder.RequiresCoordination = true;
            builder.NeedsPatience = true;
            builder.BePatient();
            builder.Practice();
            builder.Build();
            builder.UsePowerTools();

            var musician = new playMusic();
            musician.isCreative = true;
            musician.NeedsPatience = true;
            musician.RequiresCoordination = true;
            musician.NeedsPatience = true;
            musician.BePatient();
            musician.Practice();
            musician.Preference();
            musician.Instrument();

            var violinist = new playMusic();
            violinist.isCreative = true;
            violinist.NeedsPatience = true;
            violinist.RequiresCoordination = true;
            violinist.NeedsPatience = true;
            violinist.BePatient();
            violinist.Practice();
            violinist.Preference();
            violinist.Instrument();

            var cellist = new playMusic();
            cellist.isCreative = true;
            cellist.NeedsPatience = true;
            cellist.RequiresCoordination = true;
            cellist.NeedsPatience = true;
            cellist.BePatient();
            cellist.Practice();
            cellist.Preference();
            cellist.Instrument();

            var gamer = new VideoGames();
            gamer.isCreative = true;
            gamer.NeedsPatience = true;
            gamer.RequiresCoordination = true;
            gamer.NeedsPatience = true;
            gamer.BePatient();
            gamer.Practice();
            gamer.likesGames();
            gamer.GameSystem();

            var gamester = new VideoGames();
            gamester.isCreative = true;
            gamester.NeedsPatience = true;
            gamester.RequiresCoordination = true;
            gamester.NeedsPatience = true;
            gamester.BePatient();
            gamester.Practice();
            gamester.likesGames();
            gamester.GameSystem();

            var gameMeister = new VideoGames();
           gameMeister.isCreative = true;
           gameMeister.NeedsPatience = true;
           gameMeister.RequiresCoordination = true;
           gameMeister.NeedsPatience = true;
           gameMeister.BePatient();
           gameMeister.Practice();
           gameMeister.likesGames();
           gameMeister.GameSystem();


        }
    }
}
