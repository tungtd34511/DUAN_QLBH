﻿namespace _3_GUI_PresentationLayer.Views
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.customPanel1 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.img_User = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.Controls.Add(this.img_User);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(440, 537);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // img_User
            // 
            this.img_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_User.BorderColor = System.Drawing.Color.Silver;
            this.img_User.BorderFocusColor = System.Drawing.Color.HotPink;
            this.img_User.BorderRadius = 125;
            this.img_User.BorderSize = 1;
            this.img_User.Location = new System.Drawing.Point(95, 34);
            this.img_User.Name = "img_User";
            this.img_User.Size = new System.Drawing.Size(250, 250);
            this.img_User.TabIndex = 6;
            this.img_User.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_welcome
            // 
            this.txt_welcome.AutoSize = true;
            this.txt_welcome.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_welcome.Location = new System.Drawing.Point(136, 20);
            this.txt_welcome.Name = "txt_welcome";
            this.txt_welcome.Size = new System.Drawing.Size(209, 37);
            this.txt_welcome.TabIndex = 4;
            this.txt_welcome.Text = "Cin chào, Tùng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_welcome);
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 92);
            this.panel1.TabIndex = 7;
            // 
            // frmWelcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 537);
            this.Controls.Add(this.customPanel1);
            this.Name = "frmWelcome";
            this.Text = "frmWelcome";
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.CustomPanel customPanel1;
        private System.Windows.Forms.Label txt_welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControl.CustomPanel img_User;
        private System.Windows.Forms.Panel panel1;
    }
}