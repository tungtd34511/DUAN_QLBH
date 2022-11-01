using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.Views
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.rjDropdownMenu1 = new _3_GUI_PresentationLayer.CustomControl.RJDropdownMenu(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_title = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panl_menu = new System.Windows.Forms.Panel();
            this.tbl_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.panl_Logo = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.tbl_Logo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.vbButton2 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.customPanel1 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.button2 = new FontAwesome.Sharp.IconButton();
            this.img_user = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.panlMenu1 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.btn_Trangchu = new FontAwesome.Sharp.IconButton();
            this.panlMenu2 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.btn_nhanvien = new FontAwesome.Sharp.IconButton();
            this.panlMenu3 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.btn_SanPham = new FontAwesome.Sharp.IconButton();
            this.panlMenu4 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.btn_HoaDon = new FontAwesome.Sharp.IconButton();
            this.panlMenu5 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.btn_ThanhToan = new FontAwesome.Sharp.IconButton();
            this.panlMenu6 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.btn_KhuyenMai = new FontAwesome.Sharp.IconButton();
            this.panlMenu7 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjDropdownMenu1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panl_menu.SuspendLayout();
            this.tbl_Menu.SuspendLayout();
            this.panl_Logo.SuspendLayout();
            this.tbl_Logo.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.panlMenu1.SuspendLayout();
            this.panlMenu2.SuspendLayout();
            this.panlMenu3.SuspendLayout();
            this.panlMenu4.SuspendLayout();
            this.panlMenu5.SuspendLayout();
            this.panlMenu6.SuspendLayout();
            this.panlMenu7.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.BackColor = System.Drawing.Color.White;
            this.rjDropdownMenu1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.ShowImageMargin = false;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(296, 132);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(295, 32);
            this.toolStripMenuItem2.Text = "Sign in as TungTDPH16451";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(295, 32);
            this.toolStripMenuItem3.Text = "You profile";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(295, 32);
            this.toolStripMenuItem4.Text = "You History";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(295, 32);
            this.toolStripMenuItem5.Text = "Logout";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btn_title);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.panl_menu);
            this.panel2.Controls.Add(this.panelDesktop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1902, 991);
            this.panel2.TabIndex = 6;
            // 
            // btn_title
            // 
            this.btn_title.AutoSize = true;
            this.btn_title.BackColor = System.Drawing.Color.White;
            this.btn_title.BackgroundColor = System.Drawing.Color.White;
            this.btn_title.BorderColor = System.Drawing.Color.Silver;
            this.btn_title.BorderRadius = 5;
            this.btn_title.BorderSize = 1;
            this.btn_title.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btn_title.FlatAppearance.BorderSize = 0;
            this.btn_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.btn_title.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_title.IconColor = System.Drawing.Color.Black;
            this.btn_title.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_title.IconSize = 1;
            this.btn_title.Location = new System.Drawing.Point(0, 0);
            this.btn_title.Name = "btn_title";
            this.btn_title.Size = new System.Drawing.Size(66, 49);
            this.btn_title.TabIndex = 7;
            this.btn_title.Text = "vbBu";
            this.btn_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.btn_title.UseVisualStyleBackColor = false;
            this.btn_title.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(57, 475);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(40, 40);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // panl_menu
            // 
            this.panl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panl_menu.Controls.Add(this.tbl_Menu);
            this.panl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panl_menu.Location = new System.Drawing.Point(0, 0);
            this.panl_menu.Margin = new System.Windows.Forms.Padding(0);
            this.panl_menu.Name = "panl_menu";
            this.panl_menu.Size = new System.Drawing.Size(400, 991);
            this.panl_menu.TabIndex = 8;
            this.panl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panl_menu_Paint);
            // 
            // tbl_Menu
            // 
            this.tbl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.tbl_Menu.ColumnCount = 1;
            this.tbl_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Menu.Controls.Add(this.panl_Logo, 0, 0);
            this.tbl_Menu.Controls.Add(this.customPanel1, 0, 1);
            this.tbl_Menu.Controls.Add(this.panlMenu1, 0, 2);
            this.tbl_Menu.Controls.Add(this.panlMenu2, 0, 3);
            this.tbl_Menu.Controls.Add(this.panlMenu3, 0, 4);
            this.tbl_Menu.Controls.Add(this.panlMenu4, 0, 5);
            this.tbl_Menu.Controls.Add(this.panlMenu5, 0, 6);
            this.tbl_Menu.Controls.Add(this.panlMenu6, 0, 7);
            this.tbl_Menu.Controls.Add(this.panlMenu7, 0, 9);
            this.tbl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Menu.Location = new System.Drawing.Point(0, 0);
            this.tbl_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_Menu.Name = "tbl_Menu";
            this.tbl_Menu.RowCount = 10;
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 322F));
            this.tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbl_Menu.Size = new System.Drawing.Size(400, 991);
            this.tbl_Menu.TabIndex = 0;
            this.tbl_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_Menu_Paint);
            // 
            // panl_Logo
            // 
            this.panl_Logo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.panl_Logo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panl_Logo.BorderRadius = 0;
            this.panl_Logo.BorderSize = 2;
            this.panl_Logo.Controls.Add(this.tbl_Logo);
            this.panl_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panl_Logo.Location = new System.Drawing.Point(5, 5);
            this.panl_Logo.Margin = new System.Windows.Forms.Padding(5);
            this.panl_Logo.Name = "panl_Logo";
            this.panl_Logo.Size = new System.Drawing.Size(390, 90);
            this.panl_Logo.TabIndex = 7;
            this.panl_Logo.UnderlinedStyle = false;
            // 
            // tbl_Logo
            // 
            this.tbl_Logo.ColumnCount = 2;
            this.tbl_Logo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tbl_Logo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Logo.Controls.Add(this.label1, 1, 0);
            this.tbl_Logo.Controls.Add(this.vbButton2, 0, 0);
            this.tbl_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Logo.Location = new System.Drawing.Point(0, 0);
            this.tbl_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_Logo.Name = "tbl_Logo";
            this.tbl_Logo.RowCount = 1;
            this.tbl_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Logo.Size = new System.Drawing.Size(390, 90);
            this.tbl_Logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "EGALE";
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.White;
            this.vbButton2.BackgroundColor = System.Drawing.Color.White;
            this.vbButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vbButton2.BackgroundImage")));
            this.vbButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 45;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.vbButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.Black;
            this.vbButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.vbButton2.IconColor = System.Drawing.Color.Black;
            this.vbButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vbButton2.Location = new System.Drawing.Point(0, 0);
            this.vbButton2.Margin = new System.Windows.Forms.Padding(0);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(90, 90);
            this.vbButton2.TabIndex = 3;
            this.vbButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vbButton2.TextColor = System.Drawing.Color.Black;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.White;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.button2);
            this.customPanel1.Controls.Add(this.img_user);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(19, 105);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(19, 5, 21, 5);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.customPanel1.Size = new System.Drawing.Size(360, 60);
            this.customPanel1.TabIndex = 8;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.button2.IconColor = System.Drawing.Color.Black;
            this.button2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button2.IconSize = 20;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(57, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.button2.Size = new System.Drawing.Size(300, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Duy Tùng";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // img_user
            // 
            this.img_user.BackColor = System.Drawing.Color.LightGray;
            this.img_user.BackgroundColor = System.Drawing.Color.LightGray;
            this.img_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_user.BorderColor = System.Drawing.Color.Black;
            this.img_user.BorderRadius = 26;
            this.img_user.BorderSize = 0;
            this.img_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_user.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_user.FlatAppearance.BorderSize = 0;
            this.img_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.img_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.img_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.img_user.ForeColor = System.Drawing.Color.Black;
            this.img_user.IconChar = FontAwesome.Sharp.IconChar.None;
            this.img_user.IconColor = System.Drawing.Color.Black;
            this.img_user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.img_user.Location = new System.Drawing.Point(3, 3);
            this.img_user.Name = "img_user";
            this.img_user.Size = new System.Drawing.Size(54, 54);
            this.img_user.TabIndex = 2;
            this.img_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.img_user.TextColor = System.Drawing.Color.Black;
            this.img_user.UseVisualStyleBackColor = false;
            this.img_user.Click += new System.EventHandler(this.img_user_Click);
            // 
            // panlMenu1
            // 
            this.panlMenu1.BackColor = System.Drawing.Color.Transparent;
            this.panlMenu1.BorderColor = System.Drawing.Color.Transparent;
            this.panlMenu1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panlMenu1.BorderRadius = 7;
            this.panlMenu1.BorderSize = 1;
            this.panlMenu1.Controls.Add(this.btn_Trangchu);
            this.panlMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlMenu1.Location = new System.Drawing.Point(5, 175);
            this.panlMenu1.Margin = new System.Windows.Forms.Padding(5);
            this.panlMenu1.Name = "panlMenu1";
            this.panlMenu1.Size = new System.Drawing.Size(390, 60);
            this.panlMenu1.TabIndex = 9;
            this.panlMenu1.UnderlinedStyle = false;
            // 
            // btn_Trangchu
            // 
            this.btn_Trangchu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Trangchu.FlatAppearance.BorderSize = 0;
            this.btn_Trangchu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Trangchu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trangchu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Trangchu.ForeColor = System.Drawing.Color.White;
            this.btn_Trangchu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Trangchu.IconColor = System.Drawing.Color.White;
            this.btn_Trangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Trangchu.Location = new System.Drawing.Point(5, 5);
            this.btn_Trangchu.Name = "btn_Trangchu";
            this.btn_Trangchu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Trangchu.Size = new System.Drawing.Size(380, 50);
            this.btn_Trangchu.TabIndex = 0;
            this.btn_Trangchu.Text = "        Trang Chủ";
            this.btn_Trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Trangchu.UseVisualStyleBackColor = false;
            this.btn_Trangchu.Click += new System.EventHandler(this.Btn_Trangchu_Click);
            // 
            // panlMenu2
            // 
            this.panlMenu2.BorderColor = System.Drawing.Color.Transparent;
            this.panlMenu2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panlMenu2.BorderRadius = 7;
            this.panlMenu2.BorderSize = 1;
            this.panlMenu2.Controls.Add(this.btn_nhanvien);
            this.panlMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlMenu2.Location = new System.Drawing.Point(5, 245);
            this.panlMenu2.Margin = new System.Windows.Forms.Padding(5);
            this.panlMenu2.Name = "panlMenu2";
            this.panlMenu2.Size = new System.Drawing.Size(390, 60);
            this.panlMenu2.TabIndex = 10;
            this.panlMenu2.UnderlinedStyle = false;
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_nhanvien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nhanvien.ForeColor = System.Drawing.Color.White;
            this.btn_nhanvien.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btn_nhanvien.IconColor = System.Drawing.Color.White;
            this.btn_nhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(5, 5);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_nhanvien.Size = new System.Drawing.Size(380, 50);
            this.btn_nhanvien.TabIndex = 1;
            this.btn_nhanvien.Text = "        Nhân Viên";
            this.btn_nhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhanvien.UseVisualStyleBackColor = false;
            this.btn_nhanvien.Click += new System.EventHandler(this.Btn_nhanvien_Click_1);
            // 
            // panlMenu3
            // 
            this.panlMenu3.BorderColor = System.Drawing.Color.Transparent;
            this.panlMenu3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panlMenu3.BorderRadius = 7;
            this.panlMenu3.BorderSize = 1;
            this.panlMenu3.Controls.Add(this.btn_SanPham);
            this.panlMenu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlMenu3.Location = new System.Drawing.Point(5, 315);
            this.panlMenu3.Margin = new System.Windows.Forms.Padding(5);
            this.panlMenu3.Name = "panlMenu3";
            this.panlMenu3.Size = new System.Drawing.Size(390, 60);
            this.panlMenu3.TabIndex = 11;
            this.panlMenu3.UnderlinedStyle = false;
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.Color.Transparent;
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SanPham.ForeColor = System.Drawing.Color.White;
            this.btn_SanPham.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btn_SanPham.IconColor = System.Drawing.Color.White;
            this.btn_SanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.Location = new System.Drawing.Point(5, 5);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_SanPham.Size = new System.Drawing.Size(380, 50);
            this.btn_SanPham.TabIndex = 1;
            this.btn_SanPham.Text = "        Sản Phẩm";
            this.btn_SanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SanPham.UseVisualStyleBackColor = false;
            this.btn_SanPham.Click += new System.EventHandler(this.Btn_SanPham_Click);
            // 
            // panlMenu4
            // 
            this.panlMenu4.BorderColor = System.Drawing.Color.Transparent;
            this.panlMenu4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panlMenu4.BorderRadius = 7;
            this.panlMenu4.BorderSize = 1;
            this.panlMenu4.Controls.Add(this.btn_HoaDon);
            this.panlMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlMenu4.Location = new System.Drawing.Point(5, 385);
            this.panlMenu4.Margin = new System.Windows.Forms.Padding(5);
            this.panlMenu4.Name = "panlMenu4";
            this.panlMenu4.Size = new System.Drawing.Size(390, 60);
            this.panlMenu4.TabIndex = 10;
            this.panlMenu4.UnderlinedStyle = false;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_HoaDon.FlatAppearance.BorderSize = 0;
            this.btn_HoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_HoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDon.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btn_HoaDon.IconColor = System.Drawing.Color.White;
            this.btn_HoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.Location = new System.Drawing.Point(5, 5);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_HoaDon.Size = new System.Drawing.Size(380, 50);
            this.btn_HoaDon.TabIndex = 1;
            this.btn_HoaDon.Text = "        Hóa Đơn";
            this.btn_HoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // panlMenu5
            // 
            this.panlMenu5.BorderColor = System.Drawing.Color.Transparent;
            this.panlMenu5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panlMenu5.BorderRadius = 7;
            this.panlMenu5.BorderSize = 1;
            this.panlMenu5.Controls.Add(this.btn_ThanhToan);
            this.panlMenu5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlMenu5.Location = new System.Drawing.Point(5, 455);
            this.panlMenu5.Margin = new System.Windows.Forms.Padding(5);
            this.panlMenu5.Name = "panlMenu5";
            this.panlMenu5.Size = new System.Drawing.Size(390, 60);
            this.panlMenu5.TabIndex = 10;
            this.panlMenu5.UnderlinedStyle = false;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btn_ThanhToan.IconColor = System.Drawing.Color.White;
            this.btn_ThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThanhToan.Location = new System.Drawing.Point(5, 5);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ThanhToan.Size = new System.Drawing.Size(380, 50);
            this.btn_ThanhToan.TabIndex = 1;
            this.btn_ThanhToan.Text = "        Bán Hàng";
            this.btn_ThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.Btn_ThanhToan_Click);
            // 
            // panlMenu6
            // 
            this.panlMenu6.BorderColor = System.Drawing.Color.Transparent;
            this.panlMenu6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panlMenu6.BorderRadius = 7;
            this.panlMenu6.BorderSize = 1;
            this.panlMenu6.Controls.Add(this.btn_KhuyenMai);
            this.panlMenu6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlMenu6.Location = new System.Drawing.Point(5, 525);
            this.panlMenu6.Margin = new System.Windows.Forms.Padding(5);
            this.panlMenu6.Name = "panlMenu6";
            this.panlMenu6.Size = new System.Drawing.Size(390, 60);
            this.panlMenu6.TabIndex = 10;
            this.panlMenu6.UnderlinedStyle = false;
            // 
            // btn_KhuyenMai
            // 
            this.btn_KhuyenMai.BackColor = System.Drawing.Color.Transparent;
            this.btn_KhuyenMai.FlatAppearance.BorderSize = 0;
            this.btn_KhuyenMai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_KhuyenMai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_KhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhuyenMai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btn_KhuyenMai.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btn_KhuyenMai.IconColor = System.Drawing.Color.White;
            this.btn_KhuyenMai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_KhuyenMai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhuyenMai.Location = new System.Drawing.Point(5, 5);
            this.btn_KhuyenMai.Name = "btn_KhuyenMai";
            this.btn_KhuyenMai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_KhuyenMai.Size = new System.Drawing.Size(380, 50);
            this.btn_KhuyenMai.TabIndex = 1;
            this.btn_KhuyenMai.Text = "        Khuyến Mãi";
            this.btn_KhuyenMai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KhuyenMai.UseVisualStyleBackColor = false;
            this.btn_KhuyenMai.Click += new System.EventHandler(this.btn_KhuyenMai_Click_1);
            // 
            // panlMenu7
            // 
            this.panlMenu7.BorderColor = System.Drawing.Color.Transparent;
            this.panlMenu7.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panlMenu7.BorderRadius = 7;
            this.panlMenu7.BorderSize = 1;
            this.panlMenu7.Controls.Add(this.btn_logout);
            this.panlMenu7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlMenu7.Location = new System.Drawing.Point(5, 917);
            this.panlMenu7.Margin = new System.Windows.Forms.Padding(5);
            this.panlMenu7.Name = "panlMenu7";
            this.panlMenu7.Size = new System.Drawing.Size(390, 60);
            this.panlMenu7.TabIndex = 12;
            this.panlMenu7.UnderlinedStyle = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.MattressPillow;
            this.btn_logout.IconColor = System.Drawing.Color.White;
            this.btn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(5, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(380, 50);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "        Đăng Xuất";
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDesktop.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(82, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1820, 991);
            this.panelDesktop.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1902, 991);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EGALE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.rjDropdownMenu1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panl_menu.ResumeLayout(false);
            this.tbl_Menu.ResumeLayout(false);
            this.panl_Logo.ResumeLayout(false);
            this.tbl_Logo.ResumeLayout(false);
            this.tbl_Logo.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.panlMenu1.ResumeLayout(false);
            this.panlMenu2.ResumeLayout(false);
            this.panlMenu3.ResumeLayout(false);
            this.panlMenu4.ResumeLayout(false);
            this.panlMenu5.ResumeLayout(false);
            this.panlMenu6.ResumeLayout(false);
            this.panlMenu7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControl.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private CustomControl.VBButton btn_title;
        private System.Windows.Forms.Panel panl_menu;
        private System.Windows.Forms.TableLayoutPanel tbl_Menu;
        private CustomControl.CustomPanel panl_Logo;
        private System.Windows.Forms.TableLayoutPanel tbl_Logo;
        private System.Windows.Forms.Label label1;
        private CustomControl.VBButton vbButton2;
        private CustomControl.CustomPanel customPanel1;
        private FontAwesome.Sharp.IconButton button2;
        private CustomControl.VBButton img_user;
        private CustomControl.CustomPanel panlMenu1;
        private FontAwesome.Sharp.IconButton btn_Trangchu;
        private CustomControl.CustomPanel panlMenu2;
        private FontAwesome.Sharp.IconButton btn_nhanvien;
        private CustomControl.CustomPanel panlMenu3;
        private FontAwesome.Sharp.IconButton btn_SanPham;
        private CustomControl.CustomPanel panlMenu4;
        private FontAwesome.Sharp.IconButton btn_HoaDon;
        private CustomControl.CustomPanel panlMenu5;
        private FontAwesome.Sharp.IconButton btn_ThanhToan;
        private CustomControl.CustomPanel panlMenu6;
        private FontAwesome.Sharp.IconButton btn_KhuyenMai;
        private CustomControl.CustomPanel panlMenu7;
        public FontAwesome.Sharp.IconButton btn_logout;
    }
}