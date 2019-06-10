namespace BINGO
{
    partial class frmBingo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblWinner3 = new System.Windows.Forms.Label();
            this.lblWinner2 = new System.Windows.Forms.Label();
            this.lblWinner1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblReady = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.lblcounter = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGo.Location = new System.Drawing.Point(263, 111);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(60, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.No;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(341, 111);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(263, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(564, 70);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.lblWinner3);
            this.pnlCard.Controls.Add(this.lblWinner2);
            this.pnlCard.Controls.Add(this.lblWinner1);
            this.pnlCard.Location = new System.Drawing.Point(24, 155);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(763, 519);
            this.pnlCard.TabIndex = 5;
            // 
            // lblWinner3
            // 
            this.lblWinner3.AutoSize = true;
            this.lblWinner3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner3.Location = new System.Drawing.Point(618, 183);
            this.lblWinner3.Name = "lblWinner3";
            this.lblWinner3.Size = new System.Drawing.Size(64, 29);
            this.lblWinner3.TabIndex = 2;
            this.lblWinner3.Text = "Win!";
            this.lblWinner3.Visible = false;
            // 
            // lblWinner2
            // 
            this.lblWinner2.AutoSize = true;
            this.lblWinner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner2.Location = new System.Drawing.Point(618, 120);
            this.lblWinner2.Name = "lblWinner2";
            this.lblWinner2.Size = new System.Drawing.Size(59, 29);
            this.lblWinner2.TabIndex = 1;
            this.lblWinner2.Text = "You";
            this.lblWinner2.Visible = false;
            // 
            // lblWinner1
            // 
            this.lblWinner1.AutoSize = true;
            this.lblWinner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner1.Location = new System.Drawing.Point(618, 52);
            this.lblWinner1.Name = "lblWinner1";
            this.lblWinner1.Size = new System.Drawing.Size(0, 29);
            this.lblWinner1.TabIndex = 0;
            this.lblWinner1.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(167, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Enter Name:";
            // 
            // btnDontHave
            // 
            this.btnDontHave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDontHave.Location = new System.Drawing.Point(564, 92);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(75, 23);
            this.btnDontHave.TabIndex = 7;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(44, 139);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(758, 13);
            this.lblDirections.TabIndex = 8;
            this.lblDirections.Text = "Choose one number at a time, check your card for that number if you have it click" +
    " on it, if you do not have it click the Dont Have button to call the next Number" +
    "!";
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Location = new System.Drawing.Point(137, 111);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(120, 13);
            this.lblReady.TabIndex = 9;
            this.lblReady.Text = "Are You Ready to Play?";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(733, 77);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(34, 13);
            this.count.TabIndex = 10;
            this.count.Text = "count";
            // 
            // lblcounter
            // 
            this.lblcounter.AutoSize = true;
            this.lblcounter.Location = new System.Drawing.Point(678, 78);
            this.lblcounter.Name = "lblcounter";
            this.lblcounter.Size = new System.Drawing.Size(55, 13);
            this.lblcounter.TabIndex = 11;
            this.lblcounter.Text = "#\'s called:";
            // 
            // frmBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(812, 686);
            this.Controls.Add(this.lblcounter);
            this.Controls.Add(this.count);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo);
            this.Name = "frmBingo";
            this.Text = "BINGO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Label lblWinner3;
        private System.Windows.Forms.Label lblWinner2;
        private System.Windows.Forms.Label lblWinner1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label lblcounter;
    }
}

