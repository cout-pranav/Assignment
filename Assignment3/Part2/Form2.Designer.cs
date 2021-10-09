
namespace Assignment2
{
    partial class Form2
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
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.com1L = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.com3L = new System.Windows.Forms.Label();
            this.com2L = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.prodTextBox = new System.Windows.Forms.TextBox();
            this.com1 = new System.Windows.Forms.TextBox();
            this.FirmwareVersion = new System.Windows.Forms.TextBox();
            this.com3 = new System.Windows.Forms.TextBox();
            this.com2 = new System.Windows.Forms.TextBox();
            this.circleButton1 = new Assignment2.CircleButton();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(8, 40);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(55, 34);
            this.title.TabIndex = 0;
            this.title.Text = "Device 1";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(56, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // com1L
            // 
            this.com1L.Location = new System.Drawing.Point(8, 267);
            this.com1L.Name = "com1L";
            this.com1L.Size = new System.Drawing.Size(88, 34);
            this.com1L.TabIndex = 5;
            this.com1L.Text = "Switching Freq.";
            this.com1L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Firmware version";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // com3L
            // 
            this.com3L.Location = new System.Drawing.Point(8, 356);
            this.com3L.Name = "com3L";
            this.com3L.Size = new System.Drawing.Size(70, 34);
            this.com3L.TabIndex = 7;
            this.com3L.Text = "Delay time";
            this.com3L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // com2L
            // 
            this.com2L.Location = new System.Drawing.Point(11, 313);
            this.com2L.Name = "com2L";
            this.com2L.Size = new System.Drawing.Size(73, 34);
            this.com2L.TabIndex = 6;
            this.com2L.Text = "Start Freq.";
            this.com2L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.com2L.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 34);
            this.label8.TabIndex = 9;
            this.label8.Text = "Error State";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(174, 112);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(122, 30);
            this.nameTextBox.TabIndex = 10;
            // 
            // prodTextBox
            // 
            this.prodTextBox.Location = new System.Drawing.Point(174, 163);
            this.prodTextBox.Multiline = true;
            this.prodTextBox.Name = "prodTextBox";
            this.prodTextBox.Size = new System.Drawing.Size(122, 30);
            this.prodTextBox.TabIndex = 11;
            // 
            // com1
            // 
            this.com1.Location = new System.Drawing.Point(174, 267);
            this.com1.Multiline = true;
            this.com1.Name = "com1";
            this.com1.Size = new System.Drawing.Size(122, 30);
            this.com1.TabIndex = 13;
            // 
            // FirmwareVersion
            // 
            this.FirmwareVersion.Location = new System.Drawing.Point(174, 216);
            this.FirmwareVersion.Multiline = true;
            this.FirmwareVersion.Name = "FirmwareVersion";
            this.FirmwareVersion.Size = new System.Drawing.Size(122, 30);
            this.FirmwareVersion.TabIndex = 12;
            // 
            // com3
            // 
            this.com3.Location = new System.Drawing.Point(174, 364);
            this.com3.Multiline = true;
            this.com3.Name = "com3";
            this.com3.Size = new System.Drawing.Size(122, 30);
            this.com3.TabIndex = 15;
            // 
            // com2
            // 
            this.com2.Location = new System.Drawing.Point(174, 313);
            this.com2.Multiline = true;
            this.com2.Name = "com2";
            this.com2.Size = new System.Drawing.Size(122, 30);
            this.com2.TabIndex = 14;
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.Crimson;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Location = new System.Drawing.Point(174, 408);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(41, 40);
            this.circleButton1.TabIndex = 17;
            this.circleButton1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 460);
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.com3);
            this.Controls.Add(this.com2);
            this.Controls.Add(this.com1);
            this.Controls.Add(this.FirmwareVersion);
            this.Controls.Add(this.prodTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.com3L);
            this.Controls.Add(this.com2L);
            this.Controls.Add(this.com1L);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label com1L;
        public System.Windows.Forms.Label com3L;
        public System.Windows.Forms.Label com2L;
        public System.Windows.Forms.TextBox prodTextBox;
        public System.Windows.Forms.TextBox com1;
        public System.Windows.Forms.TextBox FirmwareVersion;
        public System.Windows.Forms.TextBox com3;
        public System.Windows.Forms.TextBox com2;
        public CircleButton circleButton1;
    }
}