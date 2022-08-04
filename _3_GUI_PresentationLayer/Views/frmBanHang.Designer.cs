using System.Windows.Forms;
using _3_GUI_PresentationLayer.CustomControl;

namespace _3_GUI_PresentationLayer.Views
{
    partial class FrmBanHang
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
            this.Panl_MenuTop = new _3_GUI_PresentationLayer.CustomControl.GadientPanel();
            this.btn_Them = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.Tbl_LstOder = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panl_OderCart = new System.Windows.Forms.Panel();
            this.tblOrderCart = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customPanel3 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.tbl_lstproduct = new System.Windows.Forms.TableLayoutPanel();
            this.customPanel2 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.Btn_Reset = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Panl_Search = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.Btn_Search = new FontAwesome.Sharp.IconButton();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_ketQua = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.Btn_Fill = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Prev = new FontAwesome.Sharp.IconButton();
            this.btn_last = new FontAwesome.Sharp.IconButton();
            this.btn_next = new FontAwesome.Sharp.IconButton();
            this.btn_firt = new FontAwesome.Sharp.IconButton();
            this.lbl_lastIndex = new System.Windows.Forms.Label();
            this.txt_lstShowIndex = new System.Windows.Forms.TextBox();
            this.pan_ThanhToan = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.customPanel1 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_KhachCanTra = new System.Windows.Forms.TextBox();
            this.txt_TienThua = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_TienKhachTra = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.customPanel4 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_KhachHangName = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Btn_KH = new FontAwesome.Sharp.IconButton();
            this.vbButton5 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.vbButton4 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.Menu_Fill = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_KhachHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Panl_MenuTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panl_OderCart.SuspendLayout();
            this.panel3.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Panl_Search.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pan_ThanhToan.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panl_MenuTop
            // 
            this.Panl_MenuTop.BackColor = System.Drawing.Color.BlueViolet;
            this.Panl_MenuTop.BorderRadius = 0;
            this.Panl_MenuTop.BottomRightColor = System.Drawing.Color.BlueViolet;
            this.Panl_MenuTop.Controls.Add(this.btn_Them);
            this.Panl_MenuTop.Controls.Add(this.Tbl_LstOder);
            this.Panl_MenuTop.Controls.Add(this.button3);
            this.Panl_MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panl_MenuTop.Location = new System.Drawing.Point(0, 0);
            this.Panl_MenuTop.Margin = new System.Windows.Forms.Padding(0);
            this.Panl_MenuTop.Name = "Panl_MenuTop";
            this.Panl_MenuTop.Size = new System.Drawing.Size(1820, 39);
            this.Panl_MenuTop.TabIndex = 0;
            this.Panl_MenuTop.TopLeftColor = System.Drawing.Color.MediumOrchid;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 0;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_Them.IconColor = System.Drawing.Color.Black;
            this.btn_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Them.IconSize = 26;
            this.btn_Them.Location = new System.Drawing.Point(116, 0);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(37, 39);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // Tbl_LstOder
            // 
            this.Tbl_LstOder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tbl_LstOder.BackColor = System.Drawing.Color.Transparent;
            this.Tbl_LstOder.ColumnCount = 1;
            this.Tbl_LstOder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tbl_LstOder.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tbl_LstOder.Location = new System.Drawing.Point(0, 0);
            this.Tbl_LstOder.Name = "Tbl_LstOder";
            this.Tbl_LstOder.RowCount = 1;
            this.Tbl_LstOder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tbl_LstOder.Size = new System.Drawing.Size(116, 39);
            this.Tbl_LstOder.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1820, 1);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1428F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pan_ThanhToan, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1820, 952);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 952);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panl_OderCart);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1428, 390);
            this.panel4.TabIndex = 4;
            // 
            // panl_OderCart
            // 
            this.panl_OderCart.AutoScroll = true;
            this.panl_OderCart.BackColor = System.Drawing.SystemColors.Control;
            this.panl_OderCart.Controls.Add(this.tblOrderCart);
            this.panl_OderCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panl_OderCart.Location = new System.Drawing.Point(0, 0);
            this.panl_OderCart.Margin = new System.Windows.Forms.Padding(0);
            this.panl_OderCart.Name = "panl_OderCart";
            this.panl_OderCart.Size = new System.Drawing.Size(1428, 390);
            this.panl_OderCart.TabIndex = 0;
            // 
            // tblOrderCart
            // 
            this.tblOrderCart.AutoSize = true;
            this.tblOrderCart.BackColor = System.Drawing.SystemColors.Control;
            this.tblOrderCart.ColumnCount = 1;
            this.tblOrderCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOrderCart.Location = new System.Drawing.Point(0, 5);
            this.tblOrderCart.Margin = new System.Windows.Forms.Padding(0);
            this.tblOrderCart.Name = "tblOrderCart";
            this.tblOrderCart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tblOrderCart.RowCount = 2;
            this.tblOrderCart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrderCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblOrderCart.Size = new System.Drawing.Size(1406, 256);
            this.tblOrderCart.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customPanel3);
            this.panel3.Controls.Add(this.customPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1428, 562);
            this.panel3.TabIndex = 3;
            // 
            // customPanel3
            // 
            this.customPanel3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel3.BorderRadius = 0;
            this.customPanel3.BorderSize = 2;
            this.customPanel3.Controls.Add(this.tbl_lstproduct);
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.Location = new System.Drawing.Point(0, 50);
            this.customPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1428, 512);
            this.customPanel3.TabIndex = 1;
            this.customPanel3.UnderlinedStyle = false;
            // 
            // tbl_lstproduct
            // 
            this.tbl_lstproduct.BackColor = System.Drawing.Color.White;
            this.tbl_lstproduct.ColumnCount = 7;
            this.tbl_lstproduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tbl_lstproduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tbl_lstproduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tbl_lstproduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tbl_lstproduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tbl_lstproduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tbl_lstproduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tbl_lstproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_lstproduct.Location = new System.Drawing.Point(0, 0);
            this.tbl_lstproduct.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_lstproduct.Name = "tbl_lstproduct";
            this.tbl_lstproduct.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.tbl_lstproduct.RowCount = 2;
            this.tbl_lstproduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lstproduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lstproduct.Size = new System.Drawing.Size(1428, 512);
            this.tbl_lstproduct.TabIndex = 0;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.customPanel2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.BorderSize = 2;
            this.customPanel2.Controls.Add(this.Btn_Reset);
            this.customPanel2.Controls.Add(this.tableLayoutPanel3);
            this.customPanel2.Controls.Add(this.iconButton3);
            this.customPanel2.Controls.Add(this.Btn_Fill);
            this.customPanel2.Controls.Add(this.tableLayoutPanel2);
            this.customPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel2.Location = new System.Drawing.Point(0, 0);
            this.customPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.customPanel2.Size = new System.Drawing.Size(1428, 50);
            this.customPanel2.TabIndex = 0;
            this.customPanel2.UnderlinedStyle = false;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Btn_Reset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Btn_Reset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Reset.BorderRadius = 7;
            this.Btn_Reset.BorderSize = 0;
            this.Btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Reset.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Reset.FlatAppearance.BorderSize = 0;
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.ForeColor = System.Drawing.Color.White;
            this.Btn_Reset.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.Btn_Reset.IconColor = System.Drawing.Color.White;
            this.Btn_Reset.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Reset.IconSize = 33;
            this.Btn_Reset.Location = new System.Drawing.Point(256, 3);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Btn_Reset.Size = new System.Drawing.Size(44, 44);
            this.Btn_Reset.TabIndex = 14;
            this.Btn_Reset.TextColor = System.Drawing.Color.White;
            this.Btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.Panl_Search, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_ketQua, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(91, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(165, 44);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // Panl_Search
            // 
            this.Panl_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Panl_Search.BorderColor = System.Drawing.Color.DimGray;
            this.Panl_Search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Panl_Search.BorderRadius = 5;
            this.Panl_Search.BorderSize = 1;
            this.Panl_Search.Controls.Add(this.Btn_Search);
            this.Panl_Search.Controls.Add(this.Txt_Search);
            this.Panl_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panl_Search.Location = new System.Drawing.Point(15, 0);
            this.Panl_Search.Margin = new System.Windows.Forms.Padding(0);
            this.Panl_Search.Name = "Panl_Search";
            this.Panl_Search.Padding = new System.Windows.Forms.Padding(3);
            this.Panl_Search.Size = new System.Drawing.Size(44, 44);
            this.Panl_Search.TabIndex = 8;
            this.Panl_Search.UnderlinedStyle = false;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Btn_Search.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Search.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Search.IconSize = 25;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.Location = new System.Drawing.Point(3, 3);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.Btn_Search.Size = new System.Drawing.Size(38, 38);
            this.Btn_Search.TabIndex = 0;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.Color.White;
            this.Txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Search.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Search.Location = new System.Drawing.Point(8, 10);
            this.Txt_Search.Margin = new System.Windows.Forms.Padding(5);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.PlaceholderText = "Tìm Kiếm";
            this.Txt_Search.Size = new System.Drawing.Size(196, 29);
            this.Txt_Search.TabIndex = 1;
            this.Txt_Search.Visible = false;
            this.Txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Search_KeyDown);
            // 
            // lbl_ketQua
            // 
            this.lbl_ketQua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ketQua.AutoSize = true;
            this.lbl_ketQua.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ketQua.ForeColor = System.Drawing.Color.White;
            this.lbl_ketQua.Location = new System.Drawing.Point(62, 8);
            this.lbl_ketQua.Name = "lbl_ketQua";
            this.lbl_ketQua.Size = new System.Drawing.Size(100, 28);
            this.lbl_ketQua.TabIndex = 9;
            this.lbl_ketQua.Text = "76 kết quả";
            this.lbl_ketQua.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(47, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.iconButton3.Size = new System.Drawing.Size(44, 44);
            this.iconButton3.TabIndex = 12;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // Btn_Fill
            // 
            this.Btn_Fill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Btn_Fill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Btn_Fill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Btn_Fill.BorderRadius = 0;
            this.Btn_Fill.BorderSize = 0;
            this.Btn_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fill.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Fill.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Btn_Fill.FlatAppearance.BorderSize = 0;
            this.Btn_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.Btn_Fill.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.Btn_Fill.IconColor = System.Drawing.Color.White;
            this.Btn_Fill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Fill.IconSize = 30;
            this.Btn_Fill.Location = new System.Drawing.Point(3, 3);
            this.Btn_Fill.Name = "Btn_Fill";
            this.Btn_Fill.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Btn_Fill.Size = new System.Drawing.Size(44, 44);
            this.Btn_Fill.TabIndex = 10;
            this.Btn_Fill.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.Btn_Fill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Fill.UseVisualStyleBackColor = false;
            this.Btn_Fill.Click += new System.EventHandler(this.Btn_Fill_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Prev, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_last, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_next, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_firt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_lastIndex, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_lstShowIndex, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1145, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 44);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_Prev
            // 
            this.btn_Prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Prev.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Prev.FlatAppearance.BorderSize = 0;
            this.btn_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prev.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Prev.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btn_Prev.IconColor = System.Drawing.Color.White;
            this.btn_Prev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Prev.IconSize = 20;
            this.btn_Prev.Location = new System.Drawing.Point(40, 0);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_Prev.Size = new System.Drawing.Size(40, 44);
            this.btn_Prev.TabIndex = 0;
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.Btn_Prev_Click);
            // 
            // btn_last
            // 
            this.btn_last.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_last.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_last.FlatAppearance.BorderSize = 0;
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_last.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btn_last.IconColor = System.Drawing.Color.White;
            this.btn_last.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_last.IconSize = 20;
            this.btn_last.Location = new System.Drawing.Point(240, 0);
            this.btn_last.Margin = new System.Windows.Forms.Padding(0);
            this.btn_last.Name = "btn_last";
            this.btn_last.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_last.Size = new System.Drawing.Size(40, 44);
            this.btn_last.TabIndex = 3;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.Btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_next.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btn_next.IconColor = System.Drawing.Color.White;
            this.btn_next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_next.IconSize = 20;
            this.btn_next.Location = new System.Drawing.Point(200, 0);
            this.btn_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_next.Size = new System.Drawing.Size(40, 44);
            this.btn_next.TabIndex = 2;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.Btn_next_Click);
            // 
            // btn_firt
            // 
            this.btn_firt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_firt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_firt.FlatAppearance.BorderSize = 0;
            this.btn_firt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_firt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_firt.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btn_firt.IconColor = System.Drawing.Color.White;
            this.btn_firt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_firt.IconSize = 20;
            this.btn_firt.Location = new System.Drawing.Point(0, 0);
            this.btn_firt.Margin = new System.Windows.Forms.Padding(0);
            this.btn_firt.Name = "btn_firt";
            this.btn_firt.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_firt.Size = new System.Drawing.Size(40, 44);
            this.btn_firt.TabIndex = 1;
            this.btn_firt.UseVisualStyleBackColor = true;
            this.btn_firt.Click += new System.EventHandler(this.Btn_firt_Click);
            // 
            // lbl_lastIndex
            // 
            this.lbl_lastIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lastIndex.AutoSize = true;
            this.lbl_lastIndex.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lastIndex.ForeColor = System.Drawing.Color.White;
            this.lbl_lastIndex.Location = new System.Drawing.Point(144, 7);
            this.lbl_lastIndex.Name = "lbl_lastIndex";
            this.lbl_lastIndex.Size = new System.Drawing.Size(52, 30);
            this.lbl_lastIndex.TabIndex = 5;
            this.lbl_lastIndex.Text = "/ 20";
            this.lbl_lastIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_lstShowIndex
            // 
            this.txt_lstShowIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lstShowIndex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lstShowIndex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lstShowIndex.Location = new System.Drawing.Point(80, 5);
            this.txt_lstShowIndex.Margin = new System.Windows.Forms.Padding(0);
            this.txt_lstShowIndex.Name = "txt_lstShowIndex";
            this.txt_lstShowIndex.Size = new System.Drawing.Size(60, 34);
            this.txt_lstShowIndex.TabIndex = 6;
            this.txt_lstShowIndex.Text = "1";
            this.txt_lstShowIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lstShowIndex.TextChanged += new System.EventHandler(this.Txt_lstShowIndex_TextChanged);
            this.txt_lstShowIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_lstShowIndex_KeyPress);
            // 
            // pan_ThanhToan
            // 
            this.pan_ThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.pan_ThanhToan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pan_ThanhToan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pan_ThanhToan.BorderRadius = 0;
            this.pan_ThanhToan.BorderSize = 2;
            this.pan_ThanhToan.Controls.Add(this.customPanel1);
            this.pan_ThanhToan.Controls.Add(this.iconButton9);
            this.pan_ThanhToan.Controls.Add(this.button2);
            this.pan_ThanhToan.Controls.Add(this.tableLayoutPanel6);
            this.pan_ThanhToan.Controls.Add(this.customPanel4);
            this.pan_ThanhToan.Controls.Add(this.vbButton5);
            this.pan_ThanhToan.Controls.Add(this.vbButton4);
            this.pan_ThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_ThanhToan.Location = new System.Drawing.Point(1428, 0);
            this.pan_ThanhToan.Margin = new System.Windows.Forms.Padding(0);
            this.pan_ThanhToan.Name = "pan_ThanhToan";
            this.pan_ThanhToan.Padding = new System.Windows.Forms.Padding(5);
            this.pan_ThanhToan.Size = new System.Drawing.Size(392, 952);
            this.pan_ThanhToan.TabIndex = 1;
            this.pan_ThanhToan.UnderlinedStyle = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 5;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.txt_Note);
            this.customPanel1.Location = new System.Drawing.Point(5, 567);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.customPanel1.Size = new System.Drawing.Size(383, 148);
            this.customPanel1.TabIndex = 16;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // txt_Note
            // 
            this.txt_Note.AllowDrop = true;
            this.txt_Note.BackColor = System.Drawing.Color.White;
            this.txt_Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Note.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Note.Location = new System.Drawing.Point(3, 3);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(377, 142);
            this.txt_Note.TabIndex = 17;
            this.txt_Note.Text = "0";
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconButton9.IconColor = System.Drawing.Color.Black;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 35;
            this.iconButton9.Location = new System.Drawing.Point(13, 523);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(135, 38);
            this.iconButton9.TabIndex = 15;
            this.iconButton9.Text = "Ghi chú";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(5, 501);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(383, 3);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.59785F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.40215F));
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_GiamGia, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.txt_TongTien, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_KhachCanTra, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.txt_TienThua, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.panel5, 1, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(5, 96);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(383, 406);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.label10.Location = new System.Drawing.Point(8, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 31);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tiền khách trả:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Khách cần trả:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giảm giá:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng Tiền:";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GiamGia.BackColor = System.Drawing.Color.White;
            this.txt_GiamGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_GiamGia.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_GiamGia.Location = new System.Drawing.Point(190, 129);
            this.txt_GiamGia.Margin = new System.Windows.Forms.Padding(0);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.ReadOnly = true;
            this.txt_GiamGia.Size = new System.Drawing.Size(188, 36);
            this.txt_GiamGia.TabIndex = 13;
            this.txt_GiamGia.Text = "0";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TongTien.BackColor = System.Drawing.Color.White;
            this.txt_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TongTien.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TongTien.Location = new System.Drawing.Point(190, 49);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(0);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TongTien.Size = new System.Drawing.Size(188, 36);
            this.txt_TongTien.TabIndex = 16;
            this.txt_TongTien.Text = "0";
            // 
            // txt_KhachCanTra
            // 
            this.txt_KhachCanTra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_KhachCanTra.BackColor = System.Drawing.Color.White;
            this.txt_KhachCanTra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_KhachCanTra.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KhachCanTra.Location = new System.Drawing.Point(189, 209);
            this.txt_KhachCanTra.Margin = new System.Windows.Forms.Padding(0);
            this.txt_KhachCanTra.Name = "txt_KhachCanTra";
            this.txt_KhachCanTra.ReadOnly = true;
            this.txt_KhachCanTra.Size = new System.Drawing.Size(188, 36);
            this.txt_KhachCanTra.TabIndex = 14;
            this.txt_KhachCanTra.Text = "0";
            // 
            // txt_TienThua
            // 
            this.txt_TienThua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TienThua.BackColor = System.Drawing.Color.White;
            this.txt_TienThua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TienThua.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TienThua.Location = new System.Drawing.Point(190, 369);
            this.txt_TienThua.Margin = new System.Windows.Forms.Padding(0);
            this.txt_TienThua.Name = "txt_TienThua";
            this.txt_TienThua.ReadOnly = true;
            this.txt_TienThua.Size = new System.Drawing.Size(188, 36);
            this.txt_TienThua.TabIndex = 15;
            this.txt_TienThua.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(8, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 31);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tiền thừa :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_TienKhachTra);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(192, 248);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 74);
            this.panel5.TabIndex = 17;
            // 
            // txt_TienKhachTra
            // 
            this.txt_TienKhachTra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TienKhachTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_TienKhachTra.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_TienKhachTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.txt_TienKhachTra.Location = new System.Drawing.Point(0, 35);
            this.txt_TienKhachTra.Margin = new System.Windows.Forms.Padding(0);
            this.txt_TienKhachTra.Name = "txt_TienKhachTra";
            this.txt_TienKhachTra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_TienKhachTra.Size = new System.Drawing.Size(183, 36);
            this.txt_TienKhachTra.TabIndex = 10;
            this.txt_TienKhachTra.Text = "0";
            this.txt_TienKhachTra.TextChanged += new System.EventHandler(this.Txt_TienKhachTra_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(183, 3);
            this.panel6.TabIndex = 0;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel4.BorderRadius = 0;
            this.customPanel4.BorderSize = 2;
            this.customPanel4.Controls.Add(this.button1);
            this.customPanel4.Controls.Add(this.Txt_KhachHangName);
            this.customPanel4.Controls.Add(this.iconButton1);
            this.customPanel4.Controls.Add(this.Btn_KH);
            this.customPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel4.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customPanel4.Location = new System.Drawing.Point(5, 5);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(382, 91);
            this.customPanel4.TabIndex = 0;
            this.customPanel4.UnderlinedStyle = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 3);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Txt_KhachHangName
            // 
            this.Txt_KhachHangName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_KhachHangName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_KhachHangName.Location = new System.Drawing.Point(71, 40);
            this.Txt_KhachHangName.Name = "Txt_KhachHangName";
            this.Txt_KhachHangName.PlaceholderText = "Khách Hàng";
            this.Txt_KhachHangName.Size = new System.Drawing.Size(251, 40);
            this.Txt_KhachHangName.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 35);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 50);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Btn_KH
            // 
            this.Btn_KH.BackColor = System.Drawing.Color.White;
            this.Btn_KH.FlatAppearance.BorderSize = 0;
            this.Btn_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_KH.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.Btn_KH.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.Btn_KH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_KH.Location = new System.Drawing.Point(327, 38);
            this.Btn_KH.Name = "Btn_KH";
            this.Btn_KH.Size = new System.Drawing.Size(50, 42);
            this.Btn_KH.TabIndex = 2;
            this.Btn_KH.UseVisualStyleBackColor = false;
            this.Btn_KH.Click += new System.EventHandler(this.Btn_KH_Click);
            // 
            // vbButton5
            // 
            this.vbButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vbButton5.BackColor = System.Drawing.Color.Black;
            this.vbButton5.BackgroundColor = System.Drawing.Color.Black;
            this.vbButton5.BorderColor = System.Drawing.Color.Black;
            this.vbButton5.BorderRadius = 10;
            this.vbButton5.BorderSize = 1;
            this.vbButton5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.vbButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vbButton5.ForeColor = System.Drawing.Color.White;
            this.vbButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.vbButton5.IconColor = System.Drawing.Color.Black;
            this.vbButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vbButton5.Location = new System.Drawing.Point(12, 822);
            this.vbButton5.Name = "vbButton5";
            this.vbButton5.Size = new System.Drawing.Size(164, 87);
            this.vbButton5.TabIndex = 11;
            this.vbButton5.Text = "In";
            this.vbButton5.TextColor = System.Drawing.Color.White;
            this.vbButton5.UseVisualStyleBackColor = false;
            // 
            // vbButton4
            // 
            this.vbButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vbButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton4.BorderColor = System.Drawing.Color.Silver;
            this.vbButton4.BorderRadius = 10;
            this.vbButton4.BorderSize = 1;
            this.vbButton4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.vbButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vbButton4.ForeColor = System.Drawing.Color.White;
            this.vbButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.vbButton4.IconColor = System.Drawing.Color.Black;
            this.vbButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vbButton4.Location = new System.Drawing.Point(192, 822);
            this.vbButton4.Name = "vbButton4";
            this.vbButton4.Size = new System.Drawing.Size(163, 87);
            this.vbButton4.TabIndex = 12;
            this.vbButton4.Text = "Thanh toán";
            this.vbButton4.TextColor = System.Drawing.Color.White;
            this.vbButton4.UseVisualStyleBackColor = false;
            // 
            // Menu_Fill
            // 
            this.Menu_Fill.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_Fill.Name = "contextMenuStrip1";
            this.Menu_Fill.ShowImageMargin = false;
            this.Menu_Fill.Size = new System.Drawing.Size(186, 32);
            // 
            // Menu_KhachHang
            // 
            this.Menu_KhachHang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_KhachHang.Name = "contextMenuStrip1";
            this.Menu_KhachHang.ShowImageMargin = false;
            this.Menu_KhachHang.Size = new System.Drawing.Size(36, 4);
            // 
            // FrmBanHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1820, 991);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Panl_MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmBanHang_VisibleChanged);
            this.Panl_MenuTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panl_OderCart.ResumeLayout(false);
            this.panl_OderCart.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Panl_Search.ResumeLayout(false);
            this.Panl_Search.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pan_ThanhToan.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CustomControl.CustomPanel customPanel3;
        private System.Windows.Forms.TableLayoutPanel tbl_lstproduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panl_OderCart;
        private CustomControl.CustomPanel pan_ThanhToan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TienKhachTra;
        private CustomControl.CustomPanel customPanel4;
        private CustomControl.VBButton vbButton5;
        private CustomControl.VBButton vbButton4;
        private System.Windows.Forms.TextBox Txt_KhachHangName;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton Btn_KH;
        private System.Windows.Forms.TableLayoutPanel tblOrderCart;
        private CustomControl.CustomPanel customPanel2;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.TextBox txt_KhachCanTra;
        private System.Windows.Forms.TextBox txt_TienThua;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private FontAwesome.Sharp.IconButton iconButton9;
        private CustomControl.CustomPanel customPanel1;
        private System.Windows.Forms.TextBox txt_Note;
        private CustomControl.VBButton btn_Them;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private GadientPanel Panl_MenuTop;
        private System.Windows.Forms.TableLayoutPanel Tbl_LstOder;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btn_Prev;
        private FontAwesome.Sharp.IconButton btn_last;
        private FontAwesome.Sharp.IconButton btn_next;
        private FontAwesome.Sharp.IconButton btn_firt;
        private Label lbl_lastIndex;
        private TextBox txt_lstShowIndex;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomPanel Panl_Search;
        private TextBox Txt_Search;
        private FontAwesome.Sharp.IconButton Btn_Search;
        private Label lbl_ketQua;
        private VBButton Btn_Fill;
        private FontAwesome.Sharp.IconButton iconButton3;
        private VBButton Btn_Reset;
        private ContextMenuStrip Menu_Fill;
        private ContextMenuStrip Menu_KhachHang;
    }
}