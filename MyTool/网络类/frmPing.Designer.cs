namespace MyTool
{
    partial class frmPing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAddr = new System.Windows.Forms.TextBox();
            this.chkFregment = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTimeOut = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTTL = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxLength = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDelay = new DevExpress.XtraEditors.SpinEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDelay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxDelay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxLength);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxTTL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxTimeOut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkFregment);
            this.groupBox1.Controls.Add(this.tbxAddr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.EditValue = "";
            this.memoEdit1.Location = new System.Drawing.Point(0, 70);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.memoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.memoEdit1.Properties.ReadOnly = true;
            this.memoEdit1.Size = new System.Drawing.Size(964, 330);
            this.memoEdit1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址";
            // 
            // tbxAddr
            // 
            this.tbxAddr.Location = new System.Drawing.Point(47, 25);
            this.tbxAddr.Name = "tbxAddr";
            this.tbxAddr.Size = new System.Drawing.Size(131, 21);
            this.tbxAddr.TabIndex = 1;
            // 
            // chkFregment
            // 
            this.chkFregment.AutoSize = true;
            this.chkFregment.Location = new System.Drawing.Point(184, 28);
            this.chkFregment.Name = "chkFregment";
            this.chkFregment.Size = new System.Drawing.Size(60, 16);
            this.chkFregment.TabIndex = 2;
            this.chkFregment.Text = "不分段";
            this.chkFregment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "超时时间";
            // 
            // tbxTimeOut
            // 
            this.tbxTimeOut.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.tbxTimeOut.Location = new System.Drawing.Point(297, 26);
            this.tbxTimeOut.Name = "tbxTimeOut";
            this.tbxTimeOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbxTimeOut.Size = new System.Drawing.Size(85, 20);
            this.tbxTimeOut.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "毫秒";
            // 
            // tbxTTL
            // 
            this.tbxTTL.EditValue = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.tbxTTL.Location = new System.Drawing.Point(452, 28);
            this.tbxTTL.Name = "tbxTTL";
            this.tbxTTL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbxTTL.Properties.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tbxTTL.Properties.MinValue = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.tbxTTL.Size = new System.Drawing.Size(59, 20);
            this.tbxTTL.TabIndex = 7;
            this.tbxTTL.ToolTip = "32~255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "TTL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "包大小";
            // 
            // tbxLength
            // 
            this.tbxLength.EditValue = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.tbxLength.Location = new System.Drawing.Point(564, 29);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbxLength.Properties.MaxValue = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.tbxLength.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxLength.Size = new System.Drawing.Size(59, 20);
            this.tbxLength.TabIndex = 9;
            this.tbxLength.ToolTip = "1~65535";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bytes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "PING间隔";
            // 
            // tbxDelay
            // 
            this.tbxDelay.EditValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.tbxDelay.Location = new System.Drawing.Point(726, 30);
            this.tbxDelay.Name = "tbxDelay";
            this.tbxDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbxDelay.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbxDelay.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tbxDelay.Size = new System.Drawing.Size(59, 20);
            this.tbxDelay.TabIndex = 12;
            this.tbxDelay.ToolTip = "PING动作结束后间隔多久再次执行，范围100~100000";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(791, 29);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(58, 23);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "开始";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(855, 29);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(58, 23);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "停止";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 400);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPing";
            this.Text = "PING工具";
            this.Load += new System.EventHandler(this.frmPing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDelay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit tbxTimeOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFregment;
        private System.Windows.Forms.TextBox tbxAddr;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SpinEdit tbxDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit tbxLength;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit tbxTTL;
    }
}