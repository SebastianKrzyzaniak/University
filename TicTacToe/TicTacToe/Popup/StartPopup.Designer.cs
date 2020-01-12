namespace TicTacToe.Popup
{
    partial class StartPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPopup));
            this.LoginBackgroundPic = new System.Windows.Forms.PictureBox();
            this.port = new System.Windows.Forms.MaskedTextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.MaskedTextBox();
            this.JoinGameButton = new System.Windows.Forms.Button();
            this.ExpectGameButton = new System.Windows.Forms.Button();
            this.ipPlaceHolderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackgroundPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBackgroundPic
            // 
            this.LoginBackgroundPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBackgroundPic.BackgroundImage")));
            this.LoginBackgroundPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBackgroundPic.Location = new System.Drawing.Point(0, -1);
            this.LoginBackgroundPic.Name = "LoginBackgroundPic";
            this.LoginBackgroundPic.Size = new System.Drawing.Size(873, 375);
            this.LoginBackgroundPic.TabIndex = 5;
            this.LoginBackgroundPic.TabStop = false;
            // 
            // port
            // 
            this.port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.port.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            this.port.Location = new System.Drawing.Point(44, 146);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(61, 22);
            this.port.TabIndex = 6;
            this.port.TextChanged += new System.EventHandler(this.LoginDataChanged);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.portLabel.Location = new System.Drawing.Point(41, 126);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(38, 17);
            this.portLabel.TabIndex = 7;
            this.portLabel.Text = "Port";
            this.portLabel.TextChanged += new System.EventHandler(this.LoginDataChanged);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.ipLabel.Location = new System.Drawing.Point(41, 180);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(86, 17);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "IP oponent";
            this.ipLabel.TextChanged += new System.EventHandler(this.LoginDataChanged);
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            this.ip.Location = new System.Drawing.Point(44, 200);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(157, 22);
            this.ip.TabIndex = 8;
            this.ip.TextChanged += new System.EventHandler(this.LoginDataChanged);
            // 
            // JoinGameButton
            // 
            this.JoinGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.JoinGameButton.Enabled = false;
            this.JoinGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JoinGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            this.JoinGameButton.Location = new System.Drawing.Point(683, 109);
            this.JoinGameButton.Name = "JoinGameButton";
            this.JoinGameButton.Size = new System.Drawing.Size(167, 59);
            this.JoinGameButton.TabIndex = 10;
            this.JoinGameButton.Text = "Join Game";
            this.JoinGameButton.UseVisualStyleBackColor = false;
            this.JoinGameButton.Click += new System.EventHandler(this.JoinGameButton_Click);
            // 
            // ExpectGameButton
            // 
            this.ExpectGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(100)))));
            this.ExpectGameButton.Enabled = false;
            this.ExpectGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExpectGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            this.ExpectGameButton.Location = new System.Drawing.Point(683, 200);
            this.ExpectGameButton.Name = "ExpectGameButton";
            this.ExpectGameButton.Size = new System.Drawing.Size(167, 59);
            this.ExpectGameButton.TabIndex = 11;
            this.ExpectGameButton.Text = "Expect Game";
            this.ExpectGameButton.UseVisualStyleBackColor = false;
            this.ExpectGameButton.Click += new System.EventHandler(this.ExpectGameButton_Click);
            // 
            // ipPlaceHolderLabel
            // 
            this.ipPlaceHolderLabel.AutoSize = true;
            this.ipPlaceHolderLabel.BackColor = System.Drawing.Color.Transparent;
            this.ipPlaceHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipPlaceHolderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ipPlaceHolderLabel.Location = new System.Drawing.Point(41, 225);
            this.ipPlaceHolderLabel.Name = "ipPlaceHolderLabel";
            this.ipPlaceHolderLabel.Size = new System.Drawing.Size(0, 17);
            this.ipPlaceHolderLabel.TabIndex = 12;
            // 
            // StartPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 371);
            this.Controls.Add(this.ipPlaceHolderLabel);
            this.Controls.Add(this.ExpectGameButton);
            this.Controls.Add(this.JoinGameButton);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.port);
            this.Controls.Add(this.LoginBackgroundPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.StartPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackgroundPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginBackgroundPic;
        private System.Windows.Forms.MaskedTextBox port;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.MaskedTextBox ip;
        private System.Windows.Forms.Button JoinGameButton;
        private System.Windows.Forms.Button ExpectGameButton;
        private System.Windows.Forms.Label ipPlaceHolderLabel;
    }
}