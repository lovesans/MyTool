namespace MyTool
{
    partial class frmIPSeprate
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxColumn = new System.Windows.Forms.ComboBox();
            this.tbxList = new DevExpress.XtraEditors.MemoEdit();
            this.tbxResualt = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxResualt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "解析";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cbxCountry);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxColumn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 51);
            this.panel1.TabIndex = 1;
            // 
            // cbxColumn
            // 
            this.cbxColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColumn.FormattingEnabled = true;
            this.cbxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxColumn.Location = new System.Drawing.Point(456, 15);
            this.cbxColumn.Name = "cbxColumn";
            this.cbxColumn.Size = new System.Drawing.Size(77, 20);
            this.cbxColumn.TabIndex = 1;
            // 
            // tbxList
            // 
            this.tbxList.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbxList.Location = new System.Drawing.Point(0, 51);
            this.tbxList.Name = "tbxList";
            this.tbxList.Size = new System.Drawing.Size(391, 432);
            this.tbxList.TabIndex = 2;
            // 
            // tbxResualt
            // 
            this.tbxResualt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxResualt.Location = new System.Drawing.Point(391, 51);
            this.tbxResualt.Name = "tbxResualt";
            this.tbxResualt.Size = new System.Drawing.Size(338, 432);
            this.tbxResualt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "获取第几列数据";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "获取国家列表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxCountry
            // 
            this.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxCountry.Location = new System.Drawing.Point(129, 14);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(145, 20);
            this.cbxCountry.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "下载IP库";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "国家";
            // 
            // frmIPSeprate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 483);
            this.Controls.Add(this.tbxResualt);
            this.Controls.Add(this.tbxList);
            this.Controls.Add(this.panel1);
            this.Name = "frmIPSeprate";
            this.Text = "IP区域列表分解工具";
            this.Load += new System.EventHandler(this.frmIPSeprate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxResualt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.MemoEdit tbxList;
        private DevExpress.XtraEditors.MemoEdit tbxResualt;
        private System.Windows.Forms.ComboBox cbxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}