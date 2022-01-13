namespace Tic_Tac_Toe
{
    partial class GameBoard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Button buttonBoard1;
        private System.Windows.Forms.Button buttonBoard2;
        private System.Windows.Forms.Button buttonBoard3;
        private System.Windows.Forms.Button buttonBoard4;
        private System.Windows.Forms.Button buttonBoard5;
        private System.Windows.Forms.Button buttonBoard6;
        private System.Windows.Forms.Button buttonBoard7;
        private System.Windows.Forms.Button buttonBoard8;
        private System.Windows.Forms.Button buttonBoard9;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Design GameBoard board
        private void InitializeComponent()
        {
            this.labelTurn = new System.Windows.Forms.Label();
            this.buttonBoard1 = new System.Windows.Forms.Button();
            this.buttonBoard2 = new System.Windows.Forms.Button();
            this.buttonBoard3 = new System.Windows.Forms.Button();
            this.buttonBoard4 = new System.Windows.Forms.Button();
            this.buttonBoard5 = new System.Windows.Forms.Button();
            this.buttonBoard6 = new System.Windows.Forms.Button();
            this.buttonBoard7 = new System.Windows.Forms.Button();
            this.buttonBoard8 = new System.Windows.Forms.Button();
            this.buttonBoard9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTurn
            // 
            this.labelTurn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTurn.Location = new System.Drawing.Point(9, 34);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(421, 46);
            this.labelTurn.TabIndex = 0;
            this.labelTurn.Text = "Your Turn!";
            this.labelTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTurn.Click += new System.EventHandler(this.labelTurn_Click);
            // 
            // buttonBoard1
            // 
            this.buttonBoard1.Location = new System.Drawing.Point(49, 95);
            this.buttonBoard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoard1.Name = "buttonBoard1";
            this.buttonBoard1.Size = new System.Drawing.Size(93, 86);
            this.buttonBoard1.TabIndex = 1;
            this.buttonBoard1.UseVisualStyleBackColor = true;
            this.buttonBoard1.Click += new System.EventHandler(this.buttonBoard1_Click);
            // 
            // buttonBoard2
            // 
            this.buttonBoard2.Location = new System.Drawing.Point(167, 95);
            this.buttonBoard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoard2.Name = "buttonBoard2";
            this.buttonBoard2.Size = new System.Drawing.Size(93, 86);
            this.buttonBoard2.TabIndex = 2;
            this.buttonBoard2.UseVisualStyleBackColor = true;
            this.buttonBoard2.Click += new System.EventHandler(this.buttonBoard2_Click);
            // 
            // buttonBoard3
            // 
            this.buttonBoard3.Location = new System.Drawing.Point(285, 95);
            this.buttonBoard3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoard3.Name = "buttonBoard3";
            this.buttonBoard3.Size = new System.Drawing.Size(93, 86);
            this.buttonBoard3.TabIndex = 3;
            this.buttonBoard3.UseVisualStyleBackColor = true;
            this.buttonBoard3.Click += new System.EventHandler(this.buttonBoard3_Click);
            // 
            // buttonBoard4
            // 
            this.buttonBoard4.Location = new System.Drawing.Point(49, 198);
            this.buttonBoard4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoard4.Name = "buttonBoard4";
            this.buttonBoard4.Size = new System.Drawing.Size(93, 86);
            this.buttonBoard4.TabIndex = 4;
            this.buttonBoard4.UseVisualStyleBackColor = true;
            this.buttonBoard4.Click += new System.EventHandler(this.buttonBoard4_Click);
            // 
            // buttonBoard5
            // 
            this.buttonBoard5.Location = new System.Drawing.Point(167, 198);
            this.buttonBoard5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoard5.Name = "buttonBoard5";
            this.buttonBoard5.Size = new System.Drawing.Size(93, 86);
            this.buttonBoard5.TabIndex = 5;
            this.buttonBoard5.UseVisualStyleBackColor = true;
            this.buttonBoard5.Click += new System.EventHandler(this.buttonBoard5_Click);
            // 
            // buttonBoard6
            // 
            this.buttonBoard6.Location = new System.Drawing.Point(285, 198);
            this.buttonBoard6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoard6.Name = "buttonBoard6";
            this.buttonBoard6.Size = new System.Drawing.Size(93, 86);
            this.buttonBoard6.TabIndex = 6;
            this.buttonBoard6.UseVisualStyleBackColor = true;
            this.buttonBoard6.Click += new System.EventHandler(this.buttonBoard6_Click);
            // 
            // buttonBoard7
            // 
            this.buttonBoard7.Location = new System.Drawing.Point(49, 304);
            this.buttonBoard7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoard7.Name = "buttonBoard7";
            this.buttonBoard7.Size = new System.Drawing.Size(93, 86);
            this.buttonBoard7.TabIndex = 7;
            this.buttonBoard7.UseVisualStyleBackColor = true;
            this.buttonBoard7.Click += new System.EventHandler(this.buttonBoard7_Click);
            // 
            // buttonBoard8
            // 
            this.buttonBoard8.Location = new System.Drawing.Point(167, 304);
            this.buttonBoard8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoard8.Name = "buttonBoard8";
            this.buttonBoard8.Size = new System.Drawing.Size(93, 86);
            this.buttonBoard8.TabIndex = 8;
            this.buttonBoard8.UseVisualStyleBackColor = true;
            this.buttonBoard8.Click += new System.EventHandler(this.buttonBoard8_Click);
            // 
            // buttonBoard9
            // 
            this.buttonBoard9.Location = new System.Drawing.Point(285, 304);
            this.buttonBoard9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoard9.Name = "buttonBoard9";
            this.buttonBoard9.Size = new System.Drawing.Size(93, 86);
            this.buttonBoard9.TabIndex = 9;
            this.buttonBoard9.UseVisualStyleBackColor = true;
            this.buttonBoard9.Click += new System.EventHandler(this.buttonBoard9_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 425);
            this.Controls.Add(this.buttonBoard9);
            this.Controls.Add(this.buttonBoard8);
            this.Controls.Add(this.buttonBoard7);
            this.Controls.Add(this.buttonBoard6);
            this.Controls.Add(this.buttonBoard5);
            this.Controls.Add(this.buttonBoard4);
            this.Controls.Add(this.buttonBoard3);
            this.Controls.Add(this.buttonBoard2);
            this.Controls.Add(this.buttonBoard1);
            this.Controls.Add(this.labelTurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameBoard";
            this.Text = "Tic Tac Toe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameBoard_FormClosing);
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);

        }
    }
}