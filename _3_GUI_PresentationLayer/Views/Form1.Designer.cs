using _1_DAL_DataAcessLayer.Entities;
using Color = System.Drawing.Color;

namespace _3_GUI_PresentationLayer.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.customPanel4 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.customPanel1 = new _3_GUI_PresentationLayer.CustomControl.CustomPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.vbButton3 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vbButton2 = new _3_GUI_PresentationLayer.CustomControl.VBButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel20.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customPanel4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.Silver;
            this.customPanel4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel4.BorderRadius = 0;
            this.customPanel4.BorderSize = 2;
            this.customPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.customPanel4.Location = new System.Drawing.Point(-214, 0);
            this.customPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(414, 100);
            this.customPanel4.TabIndex = 2;
            this.customPanel4.UnderlinedStyle = false;
            // 
            // customPanel1
            // 
            this.customPanel1.AutoScroll = true;
            this.customPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(200, 100);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Firebrick;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.865249F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel20.Controls.Add(this.tableLayoutPanel4);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(3, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(194, 55);
            this.panel20.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.321964F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.67803F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel4.Controls.Add(this.vbButton3, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.vbButton2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 55);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton3.BorderRadius = 0;
            this.vbButton3.BorderSize = 0;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(139, 3);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(50, 49);
            this.vbButton3.TabIndex = 5;
            this.vbButton3.Text = "icon xóa";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-174, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá tổng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-476, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá bán";
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 0;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(3, 3);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(1, 49);
            this.vbButton2.TabIndex = 0;
            this.vbButton2.Text = "Image";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-36, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sản phẩm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-289, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 27);
            this.textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1371, 596);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private CustomControl.CustomPanel customPanel4;
        private CustomControl.CustomPanel customPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private CustomControl.VBButton vbButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private CustomControl.VBButton vbButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}