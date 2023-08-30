using Classes_GTA;
using System;

namespace gta_san_andreas
{
    class Player
    {
        static void Main(string[] args)
        {
            /*Game mission1 = new Game();

            mission1.name = "Big Smoke";
            mission1.place = "San Andreas";
            mission1.time = 5;
            mission1.cheats = "hesoyam";
            mission1.rating = 6.3;

            Game mission2 = new Game();

            mission2.name = "Bull in a China Shop";
            mission2.place = "Los Santos";
            mission2.time = 7;
            mission2.cheats = "uzumymw";
            mission2.rating = 8.2;

            Console.WriteLine(mission1.name);
            Console.WriteLine(mission2.name);*/

            Game game1 = new Game("big smoke", "san andrease", 7, "hesoyam", 6.3);

            Console.WriteLine("we r playing" + game1.name  + "in "+ game1.place + "and it will take " + game1.time + "minutes"+ "use cheat "+game1.cheats+ "has overall rating of "+ game1.rating);
            
            Game game2 = new Game("big", "los santos", 9, "zuumymw", 7.8);

            game2.time = 6;
            Console.WriteLine(game2.time);

        }
    }
}