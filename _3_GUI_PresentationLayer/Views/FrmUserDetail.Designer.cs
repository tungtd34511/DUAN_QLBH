namespace _3_GUI_PresentationLayer.Views
{
    partial class FrmUserDetail
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
            this.img_User = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Status = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.Label();
            this.txt_ChucVu = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.Label();
            this.txt_GioiTinh = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.vbButton3 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_User
            // 
            this.img_User.BackColor = System.Drawing.Color.IndianRed;
            this.img_User.BackgroundColor = System.Drawing.Color.IndianRed;
            this.img_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_User.BorderColor = System.Drawing.Color.Silver;
            this.img_User.BorderRadius = 125;
            this.img_User.BorderSize = 1;
            this.img_User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.img_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.img_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.img_User.ForeColor = System.Drawing.Color.White;
            this.img_User.IconChar = FontAwesome.Sharp.IconChar.None;
            this.img_User.IconColor = System.Drawing.Color.Black;
            this.img_User.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.img_User.Location = new System.Drawing.Point(12, 67);
            this.img_User.Name = "img_User";
            this.img_User.Size = new System.Drawing.Size(250, 250);
            this.img_User.TabIndex = 7;
            this.img_User.TextColor = System.Drawing.Color.White;
            this.img_User.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.lblName.Location = new System.Drawing.Point(12, -13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 45);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Hồ sơ";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.03064F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.96936F));
            this.tableLayoutPanel4.Controls.Add(this.txt_Status, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.txt_Email, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.txt_PhoneNumber, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txt_ChucVu, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txt_NgaySinh, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.txt_Name, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_GioiTinh, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_DiaChi, 1, 7);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 323);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(35);
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(776, 373);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // txt_Status
            // 
            this.txt_Status.AutoSize = true;
            this.txt_Status.Location = new System.Drawing.Point(186, 275);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(118, 20);
            this.txt_Status.TabIndex = 20;
            this.txt_Status.Text = "Đang hoạt động";
            // 
            // txt_Email
            // 
            this.txt_Email.AutoSize = true;
            this.txt_Email.Location = new System.Drawing.Point(186, 235);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(189, 20);
            this.txt_Email.TabIndex = 19;
            this.txt_Email.Text = "tungtdph16451@fpt.edu.vn";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.AutoSize = true;
            this.txt_PhoneNumber.Location = new System.Drawing.Point(186, 195);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(89, 20);
            this.txt_PhoneNumber.TabIndex = 18;
            this.txt_PhoneNumber.Text = "0976909518";
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.AutoSize = true;
            this.txt_ChucVu.Location = new System.Drawing.Point(186, 155);
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Size = new System.Drawing.Size(59, 20);
            this.txt_ChucVu.TabIndex = 17;
            this.txt_ChucVu.Text = "Quản lý";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.AutoSize = true;
            this.txt_NgaySinh.Location = new System.Drawing.Point(186, 115);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(85, 20);
            this.txt_NgaySinh.TabIndex = 16;
            this.txt_NgaySinh.Text = "24/11/2000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(38, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(38, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Chức Vụ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(38, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(38, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(38, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Trạng thái";
            // 
            // txt_Name
            // 
            this.txt_Name.AutoSize = true;
            this.txt_Name.Location = new System.Drawing.Point(186, 35);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(42, 20);
            this.txt_Name.TabIndex = 14;
            this.txt_Name.Text = "Tùng";
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.AutoSize = true;
            this.txt_GioiTinh.Location = new System.Drawing.Point(186, 75);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(41, 20);
            this.txt_GioiTinh.TabIndex = 15;
            this.txt_GioiTinh.Text = "Nam";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.AutoSize = true;
            this.txt_DiaChi.Location = new System.Drawing.Point(186, 315);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(537, 20);
            this.txt_DiaChi.TabIndex = 21;
            this.txt_DiaChi.Text = "Số nhà 11. TDP Thượng 3, Phường Tây Tựu ,Quận Bắc Từ Liêm,Thành Phố Hà Nội";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(416, 95);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(17, 20);
            this.lbl_Id.TabIndex = 15;
            this.lbl_Id.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(351, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "CCCD:";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Location = new System.Drawing.Point(416, 139);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(17, 20);
            this.lbl_CCCD.TabIndex = 17;
            this.lbl_CCCD.Text = "1";
            // 
            // vbButton3
            // 
            this.vbButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vbButton3.BackColor = System.Drawing.SystemColors.Control;
            this.vbButton3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vbButton3.BorderColor = System.Drawing.Color.Silver;
            this.vbButton3.BorderRadius = 5;
            this.vbButton3.BorderSize = 1;
            this.vbButton3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vbButton3.ForeColor = System.Drawing.Color.Black;
            this.vbButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.vbButton3.IconColor = System.Drawing.Color.Black;
            this.vbButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vbButton3.Location = new System.Drawing.Point(708, 706);
            this.vbButton3.Margin = new System.Windows.Forms.Padding(0);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(80, 37);
            this.vbButton3.TabIndex = 18;
            this.vbButton3.Text = "Thoát";
            this.vbButton3.TextColor = System.Drawing.Color.Black;
            this.vbButton3.UseVisualStyleBackColor = false;
            this.vbButton3.Click += new System.EventHandler(this.vbButton3_Click);
            // 
            // FrmUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.vbButton3);
            this.Controls.Add(this.lbl_CCCD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.img_User);
            this.Name = "FrmUserDetail";
            this.Text = "FrmUserDetail";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.VBButton img_User;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label txt_Status;
        private System.Windows.Forms.Label txt_Email;
        private System.Windows.Forms.Label txt_PhoneNumber;
        private System.Windows.Forms.Label txt_ChucVu;
        private System.Windows.Forms.Label txt_NgaySinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txt_Name;
        private System.Windows.Forms.Label txt_GioiTinh;
        private System.Windows.Forms.Label txt_DiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_CCCD;
        private CustomControl.VBButton vbButton3;
    }
}