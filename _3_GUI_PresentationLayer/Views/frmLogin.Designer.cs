namespace _3_GUI_PresentationLayer.Views
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelDesktopLogin = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panl_Banner = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbox_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.vbButton2 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.vbButton3 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel2 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Acc = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btn_Login = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDesktopLogin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopLogin
            // 
            this.panelDesktopLogin.BackColor = System.Drawing.Color.White;
            this.panelDesktopLogin.Controls.Add(this.tableLayoutPanel1);
            this.panelDesktopLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopLogin.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopLogin.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktopLogin.Name = "panelDesktopLogin";
            this.panelDesktopLogin.Size = new System.Drawing.Size(915, 584);
            this.panelDesktopLogin.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panl_Banner, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 584);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panl_Banner
            // 
            this.panl_Banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panl_Banner.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.panl_Banner.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panl_Banner.BorderRadius = 0;
            this.panl_Banner.BorderSize = 2;
            this.panl_Banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panl_Banner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panl_Banner.ForeColor = System.Drawing.Color.White;
            this.panl_Banner.Location = new System.Drawing.Point(0, 0);
            this.panl_Banner.Margin = new System.Windows.Forms.Padding(0);
            this.panl_Banner.Name = "panl_Banner";
            this.panl_Banner.Size = new System.Drawing.Size(457, 584);
            this.panl_Banner.TabIndex = 0;
            this.panl_Banner.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbox_HienMatKhau);
            this.panel1.Controls.Add(this.vbButton2);
            this.panel1.Controls.Add(this.vbButton3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customPanel2);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(457, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 584);
            this.panel1.TabIndex = 1;
            // 
            // cbox_HienMatKhau
            // 
            this.cbox_HienMatKhau.AutoSize = true;
            this.cbox_HienMatKhau.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_HienMatKhau.Location = new System.Drawing.Point(245, 349);
            this.cbox_HienMatKhau.Name = "cbox_HienMatKhau";
            this.cbox_HienMatKhau.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cbox_HienMatKhau.Size = new System.Drawing.Size(133, 22);
            this.cbox_HienMatKhau.TabIndex = 8;
            this.cbox_HienMatKhau.Text = "Hiện mật khẩu";
            this.cbox_HienMatKhau.UseVisualStyleBackColor = true;
            this.cbox_HienMatKhau.CheckedChanged += new System.EventHandler(this.Cbox_HienMatKhau_CheckedChanged);
            // 
            // vbButton2
            // 
            this.vbButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbButton2.BackColor = System.Drawing.Color.White;
            this.vbButton2.BackgroundColor = System.Drawing.Color.White;
            this.vbButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vbButton2.BackgroundImage")));
            this.vbButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vbButton2.BorderColor = System.Drawing.Color.Black;
            this.vbButton2.BorderRadius = 75;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.Black;
            this.vbButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.vbButton2.IconColor = System.Drawing.Color.Black;
            this.vbButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vbButton2.Location = new System.Drawing.Point(159, 20);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(150, 150);
            this.vbButton2.TabIndex = 7;
            this.vbButton2.TextColor = System.Drawing.Color.Black;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.vbButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.vbButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.vbButton3.BorderRadius = 25;
            this.vbButton3.BorderSize = 3;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.vbButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.vbButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vbButton3.Location = new System.Drawing.Point(245, 379);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(167, 52);
            this.vbButton3.TabIndex = 7;
            this.vbButton3.Text = "Đăng ký";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(29, 349);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(127, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Lưu tài khoản";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(245, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quên mật khẩu ?";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.customPanel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.BorderSize = 1;
            this.customPanel2.Controls.Add(this.tableLayoutPanel2);
            this.customPanel2.Location = new System.Drawing.Point(0, 202);
            this.customPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(458, 125);
            this.customPanel2.TabIndex = 3;
            this.customPanel2.UnderlinedStyle = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
            this.tableLayoutPanel2.Controls.Add(this.iconButton1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.iconButton2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 123);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Ghost;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(63, 55);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txt_Acc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(71, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(391, 61);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 3);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_Acc
            // 
            this.txt_Acc.BackColor = System.Drawing.Color.White;
            this.txt_Acc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Acc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Acc.Location = new System.Drawing.Point(0, 10);
            this.txt_Acc.MaxLength = 25;
            this.txt_Acc.Name = "txt_Acc";
            this.txt_Acc.Size = new System.Drawing.Size(380, 45);
            this.txt_Acc.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.txt_Pass);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(71, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(391, 62);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 3);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.White;
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Pass.Location = new System.Drawing.Point(0, 10);
            this.txt_Pass.MaxLength = 25;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '●';
            this.txt_Pass.Size = new System.Drawing.Size(380, 45);
            this.txt_Pass.TabIndex = 4;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.Location = new System.Drawing.Point(3, 64);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(63, 56);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.BackgroundColor = System.Drawing.Color.White;
            this.btn_Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btn_Login.BorderRadius = 25;
            this.btn_Login.BorderSize = 3;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btn_Login.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Login.IconColor = System.Drawing.Color.Black;
            this.btn_Login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Login.Location = new System.Drawing.Point(-32, 379);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Login.Size = new System.Drawing.Size(188, 52);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(915, 584);
            this.Controls.Add(this.panelDesktopLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EGALE";
            this.panelDesktopLogin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControl.CustomPanel panl_Banner;
        private CustomControl.VBButton vbButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private CustomControl.CustomPanel customPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Acc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.CheckBox cbox_HienMatKhau;
        private CustomControl.VBButton vbButton3;
        private CustomControl.VBButton btn_Login;
        private System.Windows.Forms.Timer timer1;
    }
}