namespace ModbusApplication
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.connectButton = new System.Windows.Forms.Button();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.holdingRegListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(128, 64);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(12, 65);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.ipAddressTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address";
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(81, 126);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(76, 17);
            this.connectedLabel.TabIndex = 6;
            this.connectedLabel.Text = "Connected";
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // holdingRegListBox
            // 
            this.holdingRegListBox.FormattingEnabled = true;
            this.holdingRegListBox.ItemHeight = 16;
            this.holdingRegListBox.Location = new System.Drawing.Point(309, 77);
            this.holdingRegListBox.Name = "holdingRegListBox";
            this.holdingRegListBox.Size = new System.Drawing.Size(120, 84);
            this.holdingRegListBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 446);
            this.Controls.Add(this.holdingRegListBox);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.connectButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ListBox holdingRegListBox;
    }
}