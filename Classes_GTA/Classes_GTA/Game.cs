using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_GTA
{
    class Game
    {
        public string name;
        public string place;
        public int time;
        public string cheats;
        public double rating;

        public Game(string progname, string progplace, int progtime, string progcheats)  // ctor
        {
            name = progname;
            place = progplace;
            time = progtime;
            cheats = progcheats;  
        }

        public Game(string progname, string progplace, int progtime, string progcheats, double prograting)  // any number of 
        {
            name = progname;
            place = progplace;
            time = progtime;
            cheats = progcheats;
            rating = prograting;
        }
        
    }
}
