using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINGO
{
    //This class is responsible for keeping track of a model of the Bingo card using ints 
    //each int represents a row, column or diagnal and if any of those == 5 then there is a winner/Bingo!
    class internalBoardClass
    {
        int r0;
        int r1;
        int r2;
        int r3;
        int r4;
        int c0;
        int c1; 
        int c2;
        int c3;
        int c4;
        int fd;
        int bd;
        //default constructor sets the ints to proper value, keeping free space in mind 
        public internalBoardClass()
        {
            r0 = 0;
            r1 = 0;
            r2 = 1;
            r3 = 0;
            r4 = 0;
            c0 = 0;
            c1 = 0;
            c2 = 1;
            c3 = 0;
            c4 = 0;
            fd = 1;
            bd = 1;
        }
        //records a called number by incrementing the row and column it falls under
        public void recordCalledNumber(int a, int b)
        {
            if ( a == 0 && b == 0)
            {
                r0++;
                c0++;
                bd++;
            }
            else if (a == 0 && b == 1)
            {
                r0++;
                c1++;
            }
            else if (a == 0 && b == 2)
            {
                r0++;
                c2++;
            }
            else if (a == 0 && b == 3)
            {
                r0++;
                c3++;
            }
            else if (a == 0 && b == 4)
            {
                fd++;
                c4++;
                r0++;
            }
            else if (a == 1 && b == 0)
            {
                r1++;
                c0++;
            }
            else if (a == 1 && b == 1)
            {
                r1++;
                c1++;
                bd++;
            }
            else if (a == 1 && b == 2)
            {
                c2++;
                r1++;
            }
            else if (a == 1 && b == 3)
            {
                c3++;
                r1++;
                fd++;
            }
            else if (a == 1 && b == 4)
            {
                c4++;
                r1++;
            }
            else if (a == 2 && b == 0)
            {
                r2++;
                c0++;

            }
            else if (a == 2 && b == 1)
            {
                c1++;
                r2++;
            }
            else if (a == 2 && b == 2)
            {
                
            }
            else if (a == 2 && b == 3)
            {
                c3++;
                r2++;
            }
            else if (a == 2 && b == 4)
            {
                c4++;
                r2++;
            }
            else if (a == 3 && b == 0)
            {
                r3++;
                c0++;
            }
            else if (a == 3 && b == 1)
            {
                c1++;
                fd++;
                r3++;
            }
            else if (a == 3 && b == 2)
            {
                c2++;
                r3++;

            }
            else if (a == 3 && b == 3)
            {
                c3++;
                r3++;
                bd++;

            }
            else if (a == 3 && b == 4)
            {
                c4++;
                r3++;
            }
            else if (a == 4 && b == 0)
            {
                r4++;
                c0++;
                fd++;
            }
            else if (a == 4 && b == 1)
            {
                c1++;
                r4++;
            }
            else if (a == 4 && b == 2)
            {
                c2++;
                r4++;
            }
            else if (a == 4 && b == 3)
            {
                c3++;
                r4++;
            }
            else if (a == 4 && b == 4)
            {
                c4++;
                bd++;
                r4++;
            }
           

        }
        //return 1 if any of the ints == 5 meaning there is a row of 5 on the card 
        //returns 0 if none of these == 5. 
        public int isWinner(int a, int b)
        {
            if (r0 == 5 || r1 == 5 || r2 == 5 || r3 == 5 || r4 == 5 || c0 == 5 || c1 == 5 || c2 == 5 || c3 == 5|| c4 == 5 || fd == 5 || bd == 5)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
