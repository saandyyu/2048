namespace _2048
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            this.btnUP = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lbl2048 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(715, 471);
            this.btnUP.Margin = new System.Windows.Forms.Padding(4);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(63, 39);
            this.btnUP.TabIndex = 2;
            this.btnUP.Text = "Up";
            this.btnUP.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(654, 508);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(63, 39);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(715, 544);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(63, 39);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(775, 508);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(63, 39);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(689, 692);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(111, 44);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.AutoSize = true;
            this.pnlBoard.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBoard.Location = new System.Drawing.Point(13, 200);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(527, 478);
            this.pnlBoard.TabIndex = 7;
            this.pnlBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoard_Paint);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(497, 9);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(107, 37);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "SCORE:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 48);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(649, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "BEST SCORE:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(678, 42);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 48);
            this.textBox2.TabIndex = 11;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(505, 105);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(99, 55);
            this.btnUndo.TabIndex = 12;
            this.btnUndo.Text = "UNDO";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Location = new System.Drawing.Point(631, 105);
            this.btnResetGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(99, 55);
            this.btnResetGame.TabIndex = 13;
            this.btnResetGame.Text = "Reset  Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(547, 218);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(324, 175);
            this.lblInstruction.TabIndex = 14;
            this.lblInstruction.Text = "Instruction: \r\nSwipe in any direction to move\r\nthe tile. If the tile matched, It " +
    "will \r\nmerge into a single tile. \r\nFor example, 2+2=4. \r\nTo win the game, Reach " +
    "2048.\r\nGOOD LUCK!";
            // 
            // lbl2048
            // 
            this.lbl2048.AutoSize = true;
            this.lbl2048.Font = new System.Drawing.Font("Franklin Gothic Medium", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2048.Location = new System.Drawing.Point(47, 23);
            this.lbl2048.Name = "lbl2048";
            this.lbl2048.Size = new System.Drawing.Size(348, 151);
            this.lbl2048.TabIndex = 15;
            this.lbl2048.Text = "2048";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnQuit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 751);
            this.Controls.Add(this.lbl2048);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lbl2048;
    }
}

