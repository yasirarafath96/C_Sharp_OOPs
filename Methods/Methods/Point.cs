using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Point
    {
        // method overloading same METHOD WITH DIFFERENT NO> OF PARAMETERS
        public int x;                                                        // variables for the class 
        public int y;

        public Point(int x, int y)                                       //  ctor for the variables
        {
            this.x = x;
            this.y = y; 
        }
        public void Move(int x, int y)                                        // method 1 - with 2 parameters
        {
            this.x = x;
            this.y = y;                                       
        }
        public void Move(Point newlocation)         // METHOD 2-  THIS: keywprd is used to call r identify that x is from another field  in the same class
        {
            this.x = newlocation.x;                        
            this.y = newlocation.y;
        }
        



    }
    public class Calculator
    {
        public void Add(params int[] numbers) { }       // params modifier can be used for one method with different no. of parameters

        //var result = calculator.Add(new int[] { 1, 2, 3, 4 } );
        //var result = calculator.Add(new int[] { 1, 2, 3, 4 });
        
    }
    
    // REF MODIFIER ARE THER I AM NOT USING IT

    // OUT MODIFIER RETURNS A VALUE OUT OF THE METHOD   
}
