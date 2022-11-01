
namespace _3_GUI_PresentationLayer.Views
{
    partial class frmQuetQR
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
            this.txt_maQR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbx_Camera = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vtn_cancel = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.btn_Save = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_maQR
            // 
            this.txt_maQR.Location = new System.Drawing.Point(135, 511);
            this.txt_maQR.Name = "txt_maQR";
            this.txt_maQR.ReadOnly = true;
            this.txt_maQR.Size = new System.Drawing.Size(151, 27);
            this.txt_maQR.TabIndex = 1;
            this.txt_maQR.TextChanged += new System.EventHandler(this.txt_maQR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(56, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cbx_Camera
            // 
            this.cbx_Camera.FormattingEnabled = true;
            this.cbx_Camera.Location = new System.Drawing.Point(135, 553);
            this.cbx_Camera.Name = "cbx_Camera";
            this.cbx_Camera.Size = new System.Drawing.Size(151, 28);
            this.cbx_Camera.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vtn_cancel
            // 
            this.vtn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vtn_cancel.BackColor = System.Drawing.Color.White;
            this.vtn_cancel.BackgroundColor = System.Drawing.Color.White;
            this.vtn_cancel.BorderColor = System.Drawing.Color.Silver;
            this.vtn_cancel.BorderRadius = 5;
            this.vtn_cancel.BorderSize = 1;
            this.vtn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.vtn_cancel.FlatAppearance.BorderSize = 0;
            this.vtn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vtn_cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vtn_cancel.ForeColor = System.Drawing.Color.Black;
            this.vtn_cancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.vtn_cancel.IconColor = System.Drawing.Color.Black;
            this.vtn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vtn_cancel.Location = new System.Drawing.Point(832, 553);
            this.vtn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.vtn_cancel.Name = "vtn_cancel";
            this.vtn_cancel.Size = new System.Drawing.Size(80, 37);
            this.vtn_cancel.TabIndex = 16;
            this.vtn_cancel.Text = "Thoát";
            this.vtn_cancel.TextColor = System.Drawing.Color.Black;
            this.vtn_cancel.UseVisualStyleBackColor = false;
            this.vtn_cancel.Click += new System.EventHandler(this.vtn_cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_Save.BorderColor = System.Drawing.Color.Silver;
            this.btn_Save.BorderRadius = 5;
            this.btn_Save.BorderSize = 1;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Save.IconColor = System.Drawing.Color.Black;
            this.btn_Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Save.Location = new System.Drawing.Point(328, 547);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 37);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Bắt đầu";
            this.btn_Save.TextColor = System.Drawing.Color.White;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.lblName.Location = new System.Drawing.Point(12, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(246, 45);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Quét Sản Phẩm";
            // 
            // frmQuetQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(952, 611);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.vtn_cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Camera);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maQR);
            this.Name = "frmQuetQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quét QR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuetQR_FormClosing);
            this.Load += new System.EventHandler(this.frmQuetQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_maQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbx_Camera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private CustomControl.VBButton vtn_cancel;
        private CustomControl.VBButton btn_Save;
        private System.Windows.Forms.Label lblName;
    }
}