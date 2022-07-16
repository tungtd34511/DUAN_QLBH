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
            this.vbButton2 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.vbButton1 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Prev = new FontAwesome.Sharp.IconButton();
            this.btn_last = new FontAwesome.Sharp.IconButton();
            this.btn_next = new FontAwesome.Sharp.IconButton();
            this.lbl_lastIndex = new System.Windows.Forms.Label();
            this.btn_firt = new FontAwesome.Sharp.IconButton();
            this.txt_lstShowIndex = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vbButton3 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.panl_LocDS = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panl_lstProduct.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sản phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vbButton2);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 99);
            this.panel1.TabIndex = 0;
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 7;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(1706, 25);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(188, 50);
            this.vbButton2.TabIndex = 2;
            this.vbButton2.Text = "Xóa sản phẩm chọn";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 7;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(1496, 25);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(188, 50);
            this.vbButton1.TabIndex = 1;
            this.vbButton1.Text = "Thêm sản phẩm";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panl_lstProduct, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(384, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1536, 750);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // panl_lstProduct
            // 
            this.panl_lstProduct.AutoScroll = true;
            this.panl_lstProduct.BackColor = System.Drawing.SystemColors.Control;
            this.panl_lstProduct.Controls.Add(this.tbl_lstProduct);
            this.panl_lstProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panl_lstProduct.Location = new System.Drawing.Point(0, 50);
            this.panl_lstProduct.Margin = new System.Windows.Forms.Padding(0);
            this.panl_lstProduct.Name = "panl_lstProduct";
            this.panl_lstProduct.Size = new System.Drawing.Size(1536, 700);
            this.panl_lstProduct.TabIndex = 4;
            // 
            // tbl_lstProduct
            // 
            this.tbl_lstProduct.BackColor = System.Drawing.Color.Transparent;
            this.tbl_lstProduct.ColumnCount = 1;
            this.tbl_lstProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_lstProduct.Location = new System.Drawing.Point(0, 0);
            this.tbl_lstProduct.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_lstProduct.Name = "tbl_lstProduct";
            this.tbl_lstProduct.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tbl_lstProduct.RowCount = 14;
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
            this.tbl_lstProduct.Size = new System.Drawing.Size(1510, 700);
            this.tbl_lstProduct.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Black;
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
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1439, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 9;
            this.label11.Text = "KH đặt";
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
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.customPanel1.BackColor = System.Drawing.Color.Black;
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.tableLayoutPanel2);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.customPanel1.Location = new System.Drawing.Point(384, 750);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.customPanel1.Size = new System.Drawing.Size(1510, 40);
            this.customPanel1.TabIndex = 4;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Prev, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_last, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_next, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_lastIndex, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_firt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_lstShowIndex, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(600, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Prev
            // 
            this.btn_Prev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Prev.FlatAppearance.BorderSize = 0;
            this.btn_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prev.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btn_Prev.IconColor = System.Drawing.Color.White;
            this.btn_Prev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Prev.IconSize = 30;
            this.btn_Prev.Location = new System.Drawing.Point(50, 0);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_Prev.Size = new System.Drawing.Size(40, 40);
            this.btn_Prev.TabIndex = 0;
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_last
            // 
            this.btn_last.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_last.FlatAppearance.BorderSize = 0;
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btn_last.IconColor = System.Drawing.Color.White;
            this.btn_last.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_last.IconSize = 30;
            this.btn_last.Location = new System.Drawing.Point(254, 0);
            this.btn_last.Margin = new System.Windows.Forms.Padding(0);
            this.btn_last.Name = "btn_last";
            this.btn_last.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_last.Size = new System.Drawing.Size(40, 40);
            this.btn_last.TabIndex = 3;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btn_next.IconColor = System.Drawing.Color.White;
            this.btn_next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_next.IconSize = 30;
            this.btn_next.Location = new System.Drawing.Point(208, 0);
            this.btn_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_next.Size = new System.Drawing.Size(40, 40);
            this.btn_next.TabIndex = 2;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_lastIndex
            // 
            this.lbl_lastIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lastIndex.AutoSize = true;
            this.lbl_lastIndex.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lastIndex.ForeColor = System.Drawing.Color.White;
            this.lbl_lastIndex.Location = new System.Drawing.Point(145, 7);
            this.lbl_lastIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lbl_lastIndex.Name = "lbl_lastIndex";
            this.lbl_lastIndex.Size = new System.Drawing.Size(54, 30);
            this.lbl_lastIndex.TabIndex = 5;
            this.lbl_lastIndex.Text = "/ 20";
            // 
            // btn_firt
            // 
            this.btn_firt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_firt.FlatAppearance.BorderSize = 0;
            this.btn_firt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_firt.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btn_firt.IconColor = System.Drawing.Color.White;
            this.btn_firt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_firt.IconSize = 30;
            this.btn_firt.Location = new System.Drawing.Point(5, 0);
            this.btn_firt.Margin = new System.Windows.Forms.Padding(0);
            this.btn_firt.Name = "btn_firt";
            this.btn_firt.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_firt.Size = new System.Drawing.Size(40, 40);
            this.btn_firt.TabIndex = 1;
            this.btn_firt.UseVisualStyleBackColor = true;
            this.btn_firt.Click += new System.EventHandler(this.btn_firt_Click);
            // 
            // txt_lstShowIndex
            // 
            this.txt_lstShowIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_lstShowIndex.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lstShowIndex.Location = new System.Drawing.Point(100, 4);
            this.txt_lstShowIndex.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.txt_lstShowIndex.Name = "txt_lstShowIndex";
            this.txt_lstShowIndex.Size = new System.Drawing.Size(42, 32);
            this.txt_lstShowIndex.TabIndex = 6;
            this.txt_lstShowIndex.Text = "1";
            this.txt_lstShowIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lstShowIndex.TextChanged += new System.EventHandler(this.txt_lstShowIndex_TextChanged);
            this.txt_lstShowIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lstShowIndex_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.vbButton3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.customPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panl_LocDS, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 99);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 790);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.vbButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton3.BorderRadius = 7;
            this.vbButton3.BorderSize = 0;
            this.vbButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(0, 750);
            this.vbButton3.Margin = new System.Windows.Forms.Padding(0);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(81, 40);
            this.vbButton3.TabIndex = 7;
            this.vbButton3.Text = "Lọc";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            // 
            // panl_LocDS
            // 
            this.panl_LocDS.AutoScroll = true;
            this.panl_LocDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panl_LocDS.Location = new System.Drawing.Point(0, 0);
            this.panl_LocDS.Margin = new System.Windows.Forms.Padding(0);
            this.panl_LocDS.Name = "panl_LocDS";
            this.panl_LocDS.Size = new System.Drawing.Size(384, 750);
            this.panl_LocDS.TabIndex = 8;
            // 
            // FrmListProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 889);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListProduct";
            this.Text = "FrmListProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panl_lstProduct.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private CustomControl.VBButton vbButton3;
        private System.Windows.Forms.Panel panl_LocDS;
    }
}