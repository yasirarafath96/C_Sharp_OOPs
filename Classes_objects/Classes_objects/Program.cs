using System;

namespace Classes_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "clash of clans";  // old school method of declaring an variable

                                                // new instance of a class OBJECT
            //Game game1 = new Game();          

            /* game1.Name = "clash of clans";     // giving values to the variable
            game1.Studio = "supercell";
            game1.rating = 4.8;
            game1.year = 2001;


                                                // now we can make n number of objects from one class
            //Game game2 = new Game();             

            game1.Name = "GTA San andreas ";     
            game1.Studio = "theft";
            game1.rating = 4.5;
            game1.year = 2005;  */


            Game game1 = new Game("clash of clans ", "supercell", 4.8, 2001);        // instead of a long method of assinging values 
                                                                                     // we can directly ude shortcut for this data assingnment
            Game game2 = new Game("gta sanandreas ", "theft", 4.9, 2005);

            Console.WriteLine(game1.Name + game1.Studio + game2.year);
            game2.rating = 5.0;
            Console.WriteLine(game2.Name + game2.Studio + game2.year);

            Console.ReadLine();
        }
    }
}