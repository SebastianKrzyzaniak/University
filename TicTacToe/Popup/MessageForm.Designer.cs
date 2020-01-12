namespace TicTacToe.Popup
{
    partial class MessageForm
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
            this.outMsg = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outMsg
            // 
            this.outMsg.AutoSize = true;
            this.outMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outMsg.Location = new System.Drawing.Point(0, 0);
            this.outMsg.Name = "outMsg";
            this.outMsg.Size = new System.Drawing.Size(0, 17);
            this.outMsg.TabIndex = 2;
            this.outMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMessage
            // 
            this.btnMessage.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMessage.Location = new System.Drawing.Point(-2, -2);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(437, 57);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 53);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.outMsg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outMsg;
        private System.Windows.Forms.Button btnMessage;
    }
}