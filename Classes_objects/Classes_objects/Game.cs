using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_objects
{
    class Game
    {
        public string Name;
        public string Studio;
        public double rating;
        public int year;

        // NOW we are making a constructor
        
        public Game(string argName , string argStudio, double argrating, int argyear)
        {
            Name = argName;
            Studio = argStudio;
            rating = argrating;
            year = argyear;
            Console.WriteLine("storing data for " + Name + "\n");
        }
    }
}
