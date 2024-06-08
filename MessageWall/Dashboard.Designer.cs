namespace MessageWall
{
    partial class Dashboard
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.MessageListBoxLabel = new System.Windows.Forms.Label();
            this.addMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(35, 38);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(112, 29);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Message";
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(153, 35);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(335, 35);
            this.MessageText.TabIndex = 1;
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 29;
            this.messageListBox.Location = new System.Drawing.Point(40, 138);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(448, 294);
            this.messageListBox.TabIndex = 3;
            this.messageListBox.TabStop = false;
            // 
            // MessageListBoxLabel
            // 
            this.MessageListBoxLabel.AutoSize = true;
            this.MessageListBoxLabel.Location = new System.Drawing.Point(35, 106);
            this.MessageListBoxLabel.Name = "MessageListBoxLabel";
            this.MessageListBoxLabel.Size = new System.Drawing.Size(124, 29);
            this.MessageListBoxLabel.TabIndex = 3;
            this.MessageListBoxLabel.Text = "Messages";
            // 
            // addMessage
            // 
            this.addMessage.Location = new System.Drawing.Point(494, 38);
            this.addMessage.Name = "addMessage";
            this.addMessage.Size = new System.Drawing.Size(109, 32);
            this.addMessage.TabIndex = 2;
            this.addMessage.Text = "Add";
            this.addMessage.UseVisualStyleBackColor = true;
            this.addMessage.Click += new System.EventHandler(this.AddMessage_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(613, 468);
            this.Controls.Add(this.addMessage);
            this.Controls.Add(this.MessageListBoxLabel);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.MessageLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Label MessageListBoxLabel;
        private System.Windows.Forms.Button addMessage;
    }
}

