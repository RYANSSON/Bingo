using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINGO
{
    // Encapsulates all data and methods used to keep track of all 
    //  the numbers that have been called so far in the creation of the board and while playing the game
    // 2/7/18 - Ryan Johnson
    //Prof. Friedman

    class UsedNumbersList
    {

        private int[] numbers;

        //default constructor sets array size to 75 and all values inside to 0
        public UsedNumbersList()
        {
            numbers = new int[75];

            for (int i = 0; i < 75; i++)
            {
                numbers[i] = 0;
            }
        }
        // returns true if the number passed through its parameter has not already been chosen.
        public Boolean isNumberUsed(int num)
        {
            Boolean used = false;
            for (int i = 1; i < 75; i++)
            {
                if (numbers[i] == num)
                {
                    used = true;
                }
            }
            return used;
        }
        // sets a number used by setting its place in the array to the number chosen. 
        public void setUsedNumber(int num)
        {
            
            for (int i = 1; i < 75; i++)
            {
                if (i == num)
                {
                    if (numbers[i] == 0)
                    {
                        numbers[i] = num;
                    }
                }
            }
            
        }
        // resets the used numbers list to all 0's 
        //used after card gets created and user is playing the game. 
        public void reset()
        {
            for (int i = 0; i < 75; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}
