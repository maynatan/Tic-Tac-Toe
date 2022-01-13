namespace Tic_Tac_Toe
{
    partial class ConnectionForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Button buttonHost;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       // Design connection form
        private void InitializeComponent()
        {
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.buttonHost = new System.Windows.Forms.Button();
            this.groupBoxConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.buttonConnect);
            this.groupBoxConnect.Controls.Add(this.textBoxHost);
            this.groupBoxConnect.Controls.Add(this.labelHost);
            this.groupBoxConnect.Location = new System.Drawing.Point(12, 14);
            this.groupBoxConnect.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxConnect.Size = new System.Drawing.Size(251, 65);
            this.groupBoxConnect.TabIndex = 0;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Connect To Game";
            this.groupBoxConnect.Enter += new System.EventHandler(this.groupBoxConnect_Enter);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(180, 28);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(56, 19);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(38, 28);
            this.textBoxHost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(139, 20);
            this.textBoxHost.TabIndex = 1;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(15, 31);
            this.labelHost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(21, 15);
            this.labelHost.TabIndex = 0;
            this.labelHost.Text = "IP:";
            // 
            // buttonHost
            // 
            this.buttonHost.Location = new System.Drawing.Point(12, 84);
            this.buttonHost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHost.Name = "buttonHost";
            this.buttonHost.Size = new System.Drawing.Size(251, 31);
            this.buttonHost.TabIndex = 3;
            this.buttonHost.Text = "Host Game";
            this.buttonHost.UseVisualStyleBackColor = true;
            this.buttonHost.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 128);
            this.Controls.Add(this.buttonHost);
            this.Controls.Add(this.groupBoxConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

