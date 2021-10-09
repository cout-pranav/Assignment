
namespace Assignment2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.device2Picture = new System.Windows.Forms.PictureBox();
            this.device1Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.device2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device1Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(249, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Show Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // device2Picture
            // 
            this.device2Picture.Image = global::Assignment2.Properties.Resources.lenze_frequezumrichter;
            this.device2Picture.Location = new System.Drawing.Point(249, 21);
            this.device2Picture.Name = "device2Picture";
            this.device2Picture.Size = new System.Drawing.Size(143, 139);
            this.device2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.device2Picture.TabIndex = 1;
            this.device2Picture.TabStop = false;
            // 
            // device1Picture
            // 
            this.device1Picture.Image = global::Assignment2.Properties.Resources.lenze_motor;
            this.device1Picture.Location = new System.Drawing.Point(12, 21);
            this.device1Picture.Name = "device1Picture";
            this.device1Picture.Size = new System.Drawing.Size(143, 139);
            this.device1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.device1Picture.TabIndex = 0;
            this.device1Picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.device2Picture);
            this.Controls.Add(this.device1Picture);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.device2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device1Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox device1Picture;
        private System.Windows.Forms.PictureBox device2Picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

