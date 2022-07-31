namespace _3_GUI_PresentationLayer.Views
{
    partial class FrmListProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Comb_OderBy = new System.Windows.Forms.ComboBox();
            this.Panl_Search = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Btn_Search = new FontAwesome.Sharp.IconButton();
            this.Btn_Reset = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.vbButton5 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.btn_XuatFile = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.vbButton2 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.vbButton1 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panl_lstProduct = new System.Windows.Forms.Panel();
            this.tbl_lstProduct = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel1 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Prev = new FontAwesome.Sharp.IconButton();
            this.btn_last = new FontAwesome.Sharp.IconButton();
            this.btn_next = new FontAwesome.Sharp.IconButton();
            this.btn_firt = new FontAwesome.Sharp.IconButton();
            this.lbl_lastIndex = new System.Windows.Forms.Label();
            this.txt_lstShowIndex = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panl_LocDS = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_HuyLoc = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.Btn_Loc = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbl_Loc = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.Panl_Search.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panl_lstProduct.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panl_LocDS.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Comb_OderBy);
            this.panel1.Controls.Add(this.Panl_Search);
            this.panel1.Controls.Add(this.Btn_Reset);
            this.panel1.Controls.Add(this.vbButton5);
            this.panel1.Controls.Add(this.btn_XuatFile);
            this.panel1.Controls.Add(this.vbButton2);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1815, 89);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(708, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sắp xếp:";
            // 
            // Comb_OderBy
            // 
            this.Comb_OderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comb_OderBy.DropDownWidth = 200;
            this.Comb_OderBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Comb_OderBy.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Comb_OderBy.FormattingEnabled = true;
            this.Comb_OderBy.Items.AddRange(new object[] {
            "Không"});
            this.Comb_OderBy.Location = new System.Drawing.Point(785, 35);
            this.Comb_OderBy.Margin = new System.Windows.Forms.Padding(0);
            this.Comb_OderBy.Name = "Comb_OderBy";
            this.Comb_OderBy.Size = new System.Drawing.Size(186, 39);
            this.Comb_OderBy.TabIndex = 7;
            this.Comb_OderBy.SelectedIndexChanged += new System.EventHandler(this.Comb_OderBy_SelectedIndexChanged);
            // 
            // Panl_Search
            // 
            this.Panl_Search.BorderColor = System.Drawing.Color.Silver;
            this.Panl_Search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Panl_Search.BorderRadius = 5;
            this.Panl_Search.BorderSize = 1;
            this.Panl_Search.Controls.Add(this.Txt_Search);
            this.Panl_Search.Controls.Add(this.Btn_Search);
            this.Panl_Search.Location = new System.Drawing.Point(284, 24);
            this.Panl_Search.Name = "Panl_Search";
            this.Panl_Search.Size = new System.Drawing.Size(354, 50);
            this.Panl_Search.TabIndex = 6;
            this.Panl_Search.UnderlinedStyle = false;
            // 
            // Txt_Search
            // 
            this.Txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Search.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Search.Location = new System.Drawing.Point(3, 11);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.PlaceholderText = "Tìm Kiếm";
            this.Txt_Search.Size = new System.Drawing.Size(295, 32);
            this.Txt_Search.TabIndex = 1;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Btn_Search.IconColor = System.Drawing.Color.DimGray;
            this.Btn_Search.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Search.IconSize = 35;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.Location = new System.Drawing.Point(304, 0);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(50, 50);
            this.Btn_Search.TabIndex = 0;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.BackColor = System.Drawing.Color.White;
            this.Btn_Reset.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Reset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Reset.BorderRadius = 7;
            this.Btn_Reset.BorderSize = 0;
            this.Btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Reset.FlatAppearance.BorderSize = 0;
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.ForeColor = System.Drawing.Color.White;
            this.Btn_Reset.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.Btn_Reset.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.Btn_Reset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reset.Location = new System.Drawing.Point(1085, 28);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(51, 50);
            this.Btn_Reset.TabIndex = 5;
            this.Btn_Reset.TextColor = System.Drawing.Color.White;
            this.Btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // vbButton5
            // 
            this.vbButton5.BackColor = System.Drawing.Color.Transparent;
            this.vbButton5.BackgroundColor = System.Drawing.Color.Transparent;
            this.vbButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton5.BorderRadius = 7;
            this.vbButton5.BorderSize = 0;
            this.vbButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbButton5.FlatAppearance.BorderSize = 0;
            this.vbButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton5.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.vbButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vbButton5.IconSize = 40;
            this.vbButton5.Location = new System.Drawing.Point(1260, 28);
            this.vbButton5.Name = "vbButton5";
            this.vbButton5.Size = new System.Drawing.Size(180, 50);
            this.vbButton5.TabIndex = 4;
            this.vbButton5.Text = "Thêm hàng loạt";
            this.vbButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vbButton5.UseVisualStyleBackColor = false;
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_XuatFile.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_XuatFile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XuatFile.BorderRadius = 7;
            this.btn_XuatFile.BorderSize = 0;
            this.btn_XuatFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XuatFile.FlatAppearance.BorderSize = 0;
            this.btn_XuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_XuatFile.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_XuatFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_XuatFile.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btn_XuatFile.IconSize = 40;
            this.btn_XuatFile.Location = new System.Drawing.Point(1450, 29);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(124, 50);
            this.btn_XuatFile.TabIndex = 3;
            this.btn_XuatFile.Text = "Xuất file";
            this.btn_XuatFile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_XuatFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XuatFile.UseVisualStyleBackColor = false;
            this.btn_XuatFile.Click += new System.EventHandler(this.Btn_XuatFile_Click);
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.Transparent;
            this.vbButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 7;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.Red;
            this.vbButton2.IconChar = FontAwesome.Sharp.IconChar.Dropbox;
            this.vbButton2.IconColor = System.Drawing.Color.Red;
            this.vbButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vbButton2.IconSize = 40;
            this.vbButton2.Location = new System.Drawing.Point(1586, 28);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(208, 50);
            this.vbButton2.TabIndex = 2;
            this.vbButton2.Text = "Ngừng kinh doanh";
            this.vbButton2.TextColor = System.Drawing.Color.Red;
            this.vbButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.Transparent;
            this.vbButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 7;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.vbButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vbButton1.IconSize = 40;
            this.vbButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vbButton1.Location = new System.Drawing.Point(1148, 28);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(101, 50);
            this.vbButton1.TabIndex = 1;
            this.vbButton1.Text = "Thêm ";
            this.vbButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.VbButton1_Click);
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.AutoSize = true;
            this.Lbl_Result.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Result.Location = new System.Drawing.Point(0, 15);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(227, 25);
            this.Lbl_Result.TabIndex = 7;
            this.Lbl_Result.Text = "Hiển thị 20 trên 50 kết quả";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panl_lstProduct, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(284, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1531, 850);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // panl_lstProduct
            // 
            this.panl_lstProduct.AutoScroll = true;
            this.panl_lstProduct.BackColor = System.Drawing.Color.White;
            this.panl_lstProduct.Controls.Add(this.tbl_lstProduct);
            this.panl_lstProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panl_lstProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panl_lstProduct.Location = new System.Drawing.Point(0, 50);
            this.panl_lstProduct.Margin = new System.Windows.Forms.Padding(0);
            this.panl_lstProduct.Name = "panl_lstProduct";
            this.panl_lstProduct.Size = new System.Drawing.Size(1531, 800);
            this.panl_lstProduct.TabIndex = 4;
            // 
            // tbl_lstProduct
            // 
            this.tbl_lstProduct.BackColor = System.Drawing.SystemColors.Control;
            this.tbl_lstProduct.ColumnCount = 1;
            this.tbl_lstProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_lstProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbl_lstProduct.Location = new System.Drawing.Point(0, 0);
            this.tbl_lstProduct.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_lstProduct.Name = "tbl_lstProduct";
            this.tbl_lstProduct.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tbl_lstProduct.RowCount = 16;
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_lstProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_lstProduct.Size = new System.Drawing.Size(1510, 800);
            this.tbl_lstProduct.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.tableLayoutPanel7.ColumnCount = 10;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 457F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel7.Controls.Add(this.label11, 9, 0);
            this.tableLayoutPanel7.Controls.Add(this.label10, 8, 0);
            this.tableLayoutPanel7.Controls.Add(this.label9, 7, 0);
            this.tableLayoutPanel7.Controls.Add(this.label8, 6, 0);
            this.tableLayoutPanel7.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.checkBox1, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1510, 50);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1429, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 23);
            this.label11.TabIndex = 9;
            this.label11.Text = "KH đặt";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1297, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tổng số lượng";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1183, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Giá vốn";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(987, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giá hiện tại";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(472, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên sản phẩm";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(280, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(201, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ảnh";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "#STT";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.Lbl_Result);
            this.customPanel1.Controls.Add(this.panel3);
            this.customPanel1.Controls.Add(this.tableLayoutPanel2);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.customPanel1.Location = new System.Drawing.Point(284, 850);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1510, 47);
            this.customPanel1.TabIndex = 4;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1510, 2);
            this.panel3.TabIndex = 1;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1225, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Prev
            // 
            this.btn_Prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Prev.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Prev.FlatAppearance.BorderSize = 0;
            this.btn_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prev.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Prev.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btn_Prev.IconColor = System.Drawing.Color.Black;
            this.btn_Prev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Prev.IconSize = 20;
            this.btn_Prev.Location = new System.Drawing.Point(40, 0);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_Prev.Size = new System.Drawing.Size(40, 40);
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
            this.btn_last.IconColor = System.Drawing.Color.Black;
            this.btn_last.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_last.IconSize = 20;
            this.btn_last.Location = new System.Drawing.Point(240, 0);
            this.btn_last.Margin = new System.Windows.Forms.Padding(0);
            this.btn_last.Name = "btn_last";
            this.btn_last.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_last.Size = new System.Drawing.Size(40, 40);
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
            this.btn_next.IconColor = System.Drawing.Color.Black;
            this.btn_next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_next.IconSize = 20;
            this.btn_next.Location = new System.Drawing.Point(200, 0);
            this.btn_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_next.Size = new System.Drawing.Size(40, 40);
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
            this.btn_firt.IconColor = System.Drawing.Color.Black;
            this.btn_firt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_firt.IconSize = 20;
            this.btn_firt.Location = new System.Drawing.Point(0, 0);
            this.btn_firt.Margin = new System.Windows.Forms.Padding(0);
            this.btn_firt.Name = "btn_firt";
            this.btn_firt.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_firt.Size = new System.Drawing.Size(40, 40);
            this.btn_firt.TabIndex = 1;
            this.btn_firt.UseVisualStyleBackColor = true;
            this.btn_firt.Click += new System.EventHandler(this.Btn_firt_Click);
            // 
            // lbl_lastIndex
            // 
            this.lbl_lastIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lastIndex.AutoSize = true;
            this.lbl_lastIndex.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lastIndex.ForeColor = System.Drawing.Color.Black;
            this.lbl_lastIndex.Location = new System.Drawing.Point(143, 7);
            this.lbl_lastIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lbl_lastIndex.Name = "lbl_lastIndex";
            this.lbl_lastIndex.Size = new System.Drawing.Size(54, 30);
            this.lbl_lastIndex.TabIndex = 5;
            this.lbl_lastIndex.Text = "/ 20";
            // 
            // txt_lstShowIndex
            // 
            this.txt_lstShowIndex.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_lstShowIndex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lstShowIndex.Location = new System.Drawing.Point(80, 6);
            this.txt_lstShowIndex.Margin = new System.Windows.Forms.Padding(0);
            this.txt_lstShowIndex.Name = "txt_lstShowIndex";
            this.txt_lstShowIndex.Size = new System.Drawing.Size(60, 34);
            this.txt_lstShowIndex.TabIndex = 6;
            this.txt_lstShowIndex.Text = "1";
            this.txt_lstShowIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lstShowIndex.TextChanged += new System.EventHandler(this.Txt_lstShowIndex_TextChanged);
            this.txt_lstShowIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_lstShowIndex_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Controls.Add(this.customPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panl_LocDS, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 94);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 850F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1815, 897);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panl_LocDS
            // 
            this.panl_LocDS.BackColor = System.Drawing.Color.White;
            this.panl_LocDS.Controls.Add(this.tableLayoutPanel4);
            this.panl_LocDS.Controls.Add(this.panel2);
            this.panl_LocDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panl_LocDS.Location = new System.Drawing.Point(0, 0);
            this.panl_LocDS.Margin = new System.Windows.Forms.Padding(0);
            this.panl_LocDS.Name = "panl_LocDS";
            this.panl_LocDS.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panl_LocDS.Size = new System.Drawing.Size(284, 850);
            this.panl_LocDS.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.65233F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.34767F));
            this.tableLayoutPanel4.Controls.Add(this.Btn_HuyLoc, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Btn_Loc, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(279, 50);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // Btn_HuyLoc
            // 
            this.Btn_HuyLoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_HuyLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Btn_HuyLoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Btn_HuyLoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_HuyLoc.BorderRadius = 7;
            this.Btn_HuyLoc.BorderSize = 1;
            this.Btn_HuyLoc.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Btn_HuyLoc.FlatAppearance.BorderSize = 0;
            this.Btn_HuyLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_HuyLoc.ForeColor = System.Drawing.Color.White;
            this.Btn_HuyLoc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_HuyLoc.IconColor = System.Drawing.Color.Black;
            this.Btn_HuyLoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_HuyLoc.Location = new System.Drawing.Point(122, 3);
            this.Btn_HuyLoc.Name = "Btn_HuyLoc";
            this.Btn_HuyLoc.Size = new System.Drawing.Size(81, 44);
            this.Btn_HuyLoc.TabIndex = 9;
            this.Btn_HuyLoc.Text = "Hủy lọc";
            this.Btn_HuyLoc.TextColor = System.Drawing.Color.White;
            this.Btn_HuyLoc.UseVisualStyleBackColor = false;
            this.Btn_HuyLoc.Click += new System.EventHandler(this.Btn_HuyLoc_Click);
            // 
            // Btn_Loc
            // 
            this.Btn_Loc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Loc.BackColor = System.Drawing.Color.White;
            this.Btn_Loc.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Loc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.Btn_Loc.BorderRadius = 7;
            this.Btn_Loc.BorderSize = 1;
            this.Btn_Loc.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Btn_Loc.FlatAppearance.BorderSize = 0;
            this.Btn_Loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Loc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.Btn_Loc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.Btn_Loc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.Btn_Loc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Loc.IconSize = 40;
            this.Btn_Loc.Location = new System.Drawing.Point(3, 3);
            this.Btn_Loc.Name = "Btn_Loc";
            this.Btn_Loc.Size = new System.Drawing.Size(101, 44);
            this.Btn_Loc.TabIndex = 8;
            this.Btn_Loc.Text = "Lọc";
            this.Btn_Loc.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.Btn_Loc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Loc.UseVisualStyleBackColor = false;
            this.Btn_Loc.Click += new System.EventHandler(this.Btn_Loc_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tbl_Loc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 800);
            this.panel2.TabIndex = 1;
            // 
            // tbl_Loc
            // 
            this.tbl_Loc.AutoSize = true;
            this.tbl_Loc.ColumnCount = 1;
            this.tbl_Loc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Loc.Location = new System.Drawing.Point(0, 0);
            this.tbl_Loc.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_Loc.Name = "tbl_Loc";
            this.tbl_Loc.RowCount = 2;
            this.tbl_Loc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Loc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Loc.Size = new System.Drawing.Size(258, 200);
            this.tbl_Loc.TabIndex = 0;
            // 
            // FrmListProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1820, 991);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListProduct";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Text = "FrmListProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panl_Search.ResumeLayout(false);
            this.Panl_Search.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panl_lstProduct.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panl_LocDS.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panl_lstProduct;
        private System.Windows.Forms.TableLayoutPanel tbl_lstProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private CustomControl.CustomPanel customPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btn_Prev;
        private FontAwesome.Sharp.IconButton btn_firt;
        private FontAwesome.Sharp.IconButton btn_last;
        private FontAwesome.Sharp.IconButton btn_next;
        private System.Windows.Forms.Label lbl_lastIndex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControl.VBButton vbButton1;
        private CustomControl.VBButton vbButton2;
        private System.Windows.Forms.TextBox txt_lstShowIndex;
        private System.Windows.Forms.Panel panl_LocDS;
        private CustomControl.VBButton vbButton5;
        private CustomControl.VBButton btn_XuatFile;
        private System.Windows.Forms.TableLayoutPanel tbl_Loc;
        private CustomControl.VBButton Btn_Reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private CustomControl.VBButton Btn_HuyLoc;
        private CustomControl.VBButton Btn_Loc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Result;
        private CustomControl.CustomPanel Panl_Search;
        private System.Windows.Forms.TextBox Txt_Search;
        private FontAwesome.Sharp.IconButton Btn_Search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Comb_OderBy;
        private System.Windows.Forms.Label label4;
    }
}