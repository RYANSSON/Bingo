using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINGO
{
    //this class contains all of the methods and data used to store the players name
    class Player
    {
        private String Name;

        public Player()
        {

        }
        //sets String name to parameter n. 
        public void setName(String n)
        {
            Name = n;
        }
        //returns the Name
        public String getName()
        {
            return Name;
        
        }
    }
}
