namespace _3_GUI_PresentationLayer.Views
{
    partial class FrmDashBoard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gadientPanel4 = new _3_GUI_PresentationLayer.CustomControl.GadientPanel();
            this.gadientPanel1 = new _3_GUI_PresentationLayer.CustomControl.GadientPanel();
            this.gadientPanel2 = new _3_GUI_PresentationLayer.CustomControl.GadientPanel();
            this.gadientPanel3 = new _3_GUI_PresentationLayer.CustomControl.GadientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.67033F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.32967F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1820, 991);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gadientPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.gadientPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gadientPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gadientPanel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 896);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gadientPanel4
            // 
            this.gadientPanel4.BorderRadius = 10;
            this.gadientPanel4.BottomRightColor = System.Drawing.Color.HotPink;
            this.gadientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadientPanel4.Location = new System.Drawing.Point(10, 682);
            this.gadientPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.gadientPanel4.Name = "gadientPanel4";
            this.gadientPanel4.Size = new System.Drawing.Size(338, 204);
            this.gadientPanel4.TabIndex = 3;
            this.gadientPanel4.TopLeftColor = System.Drawing.Color.MediumSlateBlue;
            // 
            // gadientPanel1
            // 
            this.gadientPanel1.BorderRadius = 10;
            this.gadientPanel1.BottomRightColor = System.Drawing.Color.HotPink;
            this.gadientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gadientPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.gadientPanel1.Name = "gadientPanel1";
            this.gadientPanel1.Size = new System.Drawing.Size(338, 204);
            this.gadientPanel1.TabIndex = 0;
            this.gadientPanel1.TopLeftColor = System.Drawing.Color.MediumSlateBlue;
            // 
            // gadientPanel2
            // 
            this.gadientPanel2.BorderRadius = 10;
            this.gadientPanel2.BottomRightColor = System.Drawing.Color.HotPink;
            this.gadientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadientPanel2.Location = new System.Drawing.Point(10, 234);
            this.gadientPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.gadientPanel2.Name = "gadientPanel2";
            this.gadientPanel2.Size = new System.Drawing.Size(338, 204);
            this.gadientPanel2.TabIndex = 1;
            this.gadientPanel2.TopLeftColor = System.Drawing.Color.MediumSlateBlue;
            // 
            // gadientPanel3
            // 
            this.gadientPanel3.BorderRadius = 10;
            this.gadientPanel3.BottomRightColor = System.Drawing.Color.HotPink;
            this.gadientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadientPanel3.Location = new System.Drawing.Point(10, 458);
            this.gadientPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.gadientPanel3.Name = "gadientPanel3";
            this.gadientPanel3.Size = new System.Drawing.Size(338, 204);
            this.gadientPanel3.TabIndex = 2;
            this.gadientPanel3.TopLeftColor = System.Drawing.Color.MediumSlateBlue;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống Kê";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FrmDashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1820, 991);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashBoard";
            this.Text = "FrmDashBoard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControl.GadientPanel gadientPanel1;
        private CustomControl.GadientPanel gadientPanel4;
        private CustomControl.GadientPanel gadientPanel2;
        private CustomControl.GadientPanel gadientPanel3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}