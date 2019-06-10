using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BINGO
{
    // Ryan Johnson
    //2/7/18
    //Spring 3309
    //Prof. Friedman
    //Form class
    // Holds all data and methods used by the form and tools on it. 

    public partial class frmBingo : Form
    {
        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;

        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];

        int countOfCalledNumbers;
        char CalledLetter;
        int CalledNumber;

        //a string containing bingo letters
        private string bingoLetters = "BINGO";
        //an instance of RNGType called RNGObj
        private RNGType RNGObj = new RNGType();
        //an instance of the InternalBoardClass
        private internalBoardClass IBC = new internalBoardClass();
        //an Instance of the player class
        private Player ryan = new Player();
        
        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;
        
        public frmBingo()
        {
            InitializeComponent();
        }
        //sets btnDontHave to false when form loads to keep player from calling numbers before the board is created
        private void Form1_Load(object sender, EventArgs e)
        {
            btnDontHave.Enabled = false;
        }
        //sets the Name if it is valid, enabled the Donthave button and disabled the btnGo. calls CreateCard()
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Enter a valid name!");
            }
            else
            {
                btnGo.Enabled = false;
                btnDontHave.Enabled = true;
                ryan.setName(txtName.Text.ToString());
                createCard();
                playTheGame();
            }

        }
        //Exit Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Creates the Bingo Card for Play
        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form
            

           

            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                        newButton[row, col].Enabled = false;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                        newButton[row, col].Enabled = true;
                    }  // end if    
                    
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();

            //reset the Used numbers List
            Globals.UsedNums.reset();
        } // end createBoard



        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels



        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar



        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar
        //converts a given char to its numeric value
        public static int CharToInt(char input)
        {
            double temp = Char.GetNumericValue(input);
            int result = Convert.ToInt32(temp);
            return result;
        }

        // This is the handler for all Bingo Card Buttons
        // It uses sender argument to determine which Bingo Card button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
            int bingoCount2D;
            int selectedNumber;  // number randomly selected
               

            
            int rowID = CharToInt(((Button)sender).Name[3]);
            int colID = CharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            // Double check that clicked on button value matches called value
            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);
            if (selectedNumber == CalledNumber)
            {
                newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                IBC.recordCalledNumber(rowID, colID);
                
                Globals.UsedNums.setUsedNumber(selectedNumber);

                // Check for winner
                // Go here if player found the number called in his or her card
                // Check for winner for either internal representation
                bingoCount2D = IBC.isWinner(rowID,colID);
                
                if ((bingoCount2D > 0))
                {
                    lblWinner1.Text = ryan.getName();
                    lblWinner1.Visible = true;
                    lblWinner2.Visible = true;
                    lblWinner3.Visible = true;
                    MessageBox.Show(ryan.getName() +" You are a Winner!!", "called #'s count: : \n" + countOfCalledNumbers
                        + " Bingos count: = " + (bingoCount2D) + ". Game over!");
                    Close();
                }  // end inner if

                playTheGame();
            }
            else
            {
                MessageBox.Show("Called number does not match the one in the box you selected."
                          + "Try again!", "Numbers Do Not Match");
            } // end outer if
        } // end button clickhandler 

        //Gets a new called number and displays the called Letter & Number in the txtNumber.text
        public void playTheGame()
        {
            if (countOfCalledNumbers < MAXBINGONUMBER)
            {
                countOfCalledNumbers++;
               
                    CalledNumber = RNGObj.getNextUniqueRandomValue(1, MAXBINGONUMBER);
                    CalledLetter = bingoLetters[(CalledNumber - 1) / NUMBERSPERCOLUMN];
                    txtNumber.Text = CalledLetter + " " + CalledNumber.ToString();
                    count.Text = countOfCalledNumbers.ToString();
            }
            else
            {
                MessageBox.Show("All Bingo numbers called.  \nYou must have missed one or more spaces");
                this.Close();
            } 
        }
        //calls playtheGame if there are still numbers availiable. 
        private void btnDontHave_Click(object sender, EventArgs e)
        {
            
            if(countOfCalledNumbers >= 75)
            {
                MessageBox.Show("You have ran out of numbers to call");
                this.Close();
            }
            else
            {
                playTheGame();
            }
            

        }

     
    }
   
}
