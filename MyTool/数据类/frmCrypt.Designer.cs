namespace MyTool
{
    partial class frmCrypt
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BASE64 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxBaseCrypted = new DevExpress.XtraEditors.MemoEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxBaseOrigin = new DevExpress.XtraEditors.MemoEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBaseOption = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBaseCharset = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MD5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxMD5Crypted = new DevExpress.XtraEditors.MemoEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxMD5Origin = new DevExpress.XtraEditors.MemoEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMD5Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMD5Charset = new System.Windows.Forms.ComboBox();
            this.btnMD5Crypt = new System.Windows.Forms.Button();
            this.SHA = new System.Windows.Forms.TabPage();
            this.DES = new System.Windows.Forms.TabPage();
            this.DES3 = new System.Windows.Forms.TabPage();
            this.AES = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbxMDSalt = new DevExpress.XtraEditors.MemoEdit();
            this.tabControl1.SuspendLayout();
            this.BASE64.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBaseCrypted.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBaseOrigin.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.MD5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxMD5Crypted.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxMD5Origin.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxMDSalt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BASE64);
            this.tabControl1.Controls.Add(this.MD5);
            this.tabControl1.Controls.Add(this.SHA);
            this.tabControl1.Controls.Add(this.DES);
            this.tabControl1.Controls.Add(this.DES3);
            this.tabControl1.Controls.Add(this.AES);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // BASE64
            // 
            this.BASE64.Controls.Add(this.groupBox2);
            this.BASE64.Controls.Add(this.groupBox1);
            this.BASE64.Controls.Add(this.panel1);
            this.BASE64.Location = new System.Drawing.Point(4, 22);
            this.BASE64.Name = "BASE64";
            this.BASE64.Padding = new System.Windows.Forms.Padding(3);
            this.BASE64.Size = new System.Drawing.Size(791, 517);
            this.BASE64.TabIndex = 0;
            this.BASE64.Text = "BASE64";
            this.BASE64.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxBaseCrypted);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(412, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 471);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "密文";
            // 
            // tbxBaseCrypted
            // 
            this.tbxBaseCrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBaseCrypted.Location = new System.Drawing.Point(3, 17);
            this.tbxBaseCrypted.Name = "tbxBaseCrypted";
            this.tbxBaseCrypted.Size = new System.Drawing.Size(370, 451);
            this.tbxBaseCrypted.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxBaseOrigin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 471);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原文";
            // 
            // tbxBaseOrigin
            // 
            this.tbxBaseOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBaseOrigin.Location = new System.Drawing.Point(3, 17);
            this.tbxBaseOrigin.Name = "tbxBaseOrigin";
            this.tbxBaseOrigin.Size = new System.Drawing.Size(403, 451);
            this.tbxBaseOrigin.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkBaseOption);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxBaseCharset);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 40);
            this.panel1.TabIndex = 0;
            // 
            // chkBaseOption
            // 
            this.chkBaseOption.AutoSize = true;
            this.chkBaseOption.Location = new System.Drawing.Point(348, 13);
            this.chkBaseOption.Name = "chkBaseOption";
            this.chkBaseOption.Size = new System.Drawing.Size(60, 16);
            this.chkBaseOption.TabIndex = 4;
            this.chkBaseOption.Text = "分行符";
            this.chkBaseOption.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "字符集";
            // 
            // cbxBaseCharset
            // 
            this.cbxBaseCharset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaseCharset.FormattingEnabled = true;
            this.cbxBaseCharset.Items.AddRange(new object[] {
            "UTF-7",
            "UTF-8",
            "UTF-32",
            "UNICODE",
            "ASCII",
            "GB2312",
            "GB18030",
            "GBK"});
            this.cbxBaseCharset.Location = new System.Drawing.Point(221, 11);
            this.cbxBaseCharset.Name = "cbxBaseCharset";
            this.cbxBaseCharset.Size = new System.Drawing.Size(121, 20);
            this.cbxBaseCharset.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "解密";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.tbxBaseDecrypt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "加密";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.tbxBaseEncrypt_Click);
            // 
            // MD5
            // 
            this.MD5.Controls.Add(this.groupBox3);
            this.MD5.Controls.Add(this.panel3);
            this.MD5.Controls.Add(this.panel2);
            this.MD5.Location = new System.Drawing.Point(4, 22);
            this.MD5.Name = "MD5";
            this.MD5.Padding = new System.Windows.Forms.Padding(3);
            this.MD5.Size = new System.Drawing.Size(1080, 517);
            this.MD5.TabIndex = 1;
            this.MD5.Text = "MD5";
            this.MD5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxMD5Crypted);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(502, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 471);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "密文";
            // 
            // tbxMD5Crypted
            // 
            this.tbxMD5Crypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMD5Crypted.Location = new System.Drawing.Point(3, 17);
            this.tbxMD5Crypted.Name = "tbxMD5Crypted";
            this.tbxMD5Crypted.Size = new System.Drawing.Size(569, 451);
            this.tbxMD5Crypted.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbxMD5Origin);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 240);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "原文";
            // 
            // tbxMD5Origin
            // 
            this.tbxMD5Origin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMD5Origin.Location = new System.Drawing.Point(3, 17);
            this.tbxMD5Origin.Name = "tbxMD5Origin";
            this.tbxMD5Origin.Size = new System.Drawing.Size(493, 220);
            this.tbxMD5Origin.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.radioGroup1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbxMD5Type);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxMD5Charset);
            this.panel2.Controls.Add(this.btnMD5Crypt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 40);
            this.panel2.TabIndex = 3;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(431, 9);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "MD32大"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "MD32小"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "MD16大"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "MD16小"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Base64")});
            this.radioGroup1.Size = new System.Drawing.Size(329, 25);
            this.radioGroup1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "加密方式";
            // 
            // cbxMD5Type
            // 
            this.cbxMD5Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMD5Type.FormattingEnabled = true;
            this.cbxMD5Type.Items.AddRange(new object[] {
            "md5(pass)",
            "md5(md5(pass))",
            "md5($pass.$salt)",
            "md5($salt.$pass)",
            "md5(md5($pass).$salt)",
            "md5(md5($salt).$pass)",
            "md5($salt.$pass.$salt)",
            "md5($salt.md5($pass))",
            "md5(md5($pass).md5($salt))",
            "md5(md5($salt).md5($pass))"});
            this.cbxMD5Type.Location = new System.Drawing.Point(241, 13);
            this.cbxMD5Type.Name = "cbxMD5Type";
            this.cbxMD5Type.Size = new System.Drawing.Size(121, 20);
            this.cbxMD5Type.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "字符集";
            // 
            // cbxMD5Charset
            // 
            this.cbxMD5Charset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMD5Charset.FormattingEnabled = true;
            this.cbxMD5Charset.Items.AddRange(new object[] {
            "UTF-7",
            "UTF-8",
            "UTF-32",
            "UNICODE",
            "ASCII",
            "GB2312",
            "GB18030",
            "GBK"});
            this.cbxMD5Charset.Location = new System.Drawing.Point(54, 11);
            this.cbxMD5Charset.Name = "cbxMD5Charset";
            this.cbxMD5Charset.Size = new System.Drawing.Size(121, 20);
            this.cbxMD5Charset.TabIndex = 2;
            // 
            // btnMD5Crypt
            // 
            this.btnMD5Crypt.Location = new System.Drawing.Point(766, 9);
            this.btnMD5Crypt.Name = "btnMD5Crypt";
            this.btnMD5Crypt.Size = new System.Drawing.Size(75, 23);
            this.btnMD5Crypt.TabIndex = 0;
            this.btnMD5Crypt.Text = "加密";
            this.btnMD5Crypt.UseVisualStyleBackColor = true;
            this.btnMD5Crypt.Click += new System.EventHandler(this.btnMD5Crypt_Click);
            // 
            // SHA
            // 
            this.SHA.Location = new System.Drawing.Point(4, 22);
            this.SHA.Name = "SHA";
            this.SHA.Size = new System.Drawing.Size(791, 517);
            this.SHA.TabIndex = 2;
            this.SHA.Text = "SHA";
            this.SHA.UseVisualStyleBackColor = true;
            // 
            // DES
            // 
            this.DES.Location = new System.Drawing.Point(4, 22);
            this.DES.Name = "DES";
            this.DES.Size = new System.Drawing.Size(791, 517);
            this.DES.TabIndex = 3;
            this.DES.Text = "DES";
            this.DES.UseVisualStyleBackColor = true;
            // 
            // DES3
            // 
            this.DES3.Location = new System.Drawing.Point(4, 22);
            this.DES3.Name = "DES3";
            this.DES3.Size = new System.Drawing.Size(791, 517);
            this.DES3.TabIndex = 4;
            this.DES3.Text = "3DES";
            this.DES3.UseVisualStyleBackColor = true;
            // 
            // AES
            // 
            this.AES.Location = new System.Drawing.Point(4, 22);
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(791, 517);
            this.AES.TabIndex = 5;
            this.AES.Text = "AES";
            this.AES.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "输出方式";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 471);
            this.panel3.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbxMDSalt);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(499, 231);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Salt";
            // 
            // tbxMDSalt
            // 
            this.tbxMDSalt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMDSalt.Location = new System.Drawing.Point(3, 17);
            this.tbxMDSalt.Name = "tbxMDSalt";
            this.tbxMDSalt.Size = new System.Drawing.Size(493, 211);
            this.tbxMDSalt.TabIndex = 0;
            // 
            // frmCrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 543);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCrypt";
            this.Text = "加密解密工具";
            this.tabControl1.ResumeLayout(false);
            this.BASE64.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxBaseCrypted.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxBaseOrigin.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MD5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxMD5Crypted.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxMD5Origin.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxMDSalt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BASE64;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.MemoEdit tbxBaseCrypted;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.MemoEdit tbxBaseOrigin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage MD5;
        private System.Windows.Forms.TabPage SHA;
        private System.Windows.Forms.TabPage DES;
        private System.Windows.Forms.TabPage DES3;
        private System.Windows.Forms.TabPage AES;
        private System.Windows.Forms.ComboBox cbxBaseCharset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBaseOption;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.MemoEdit tbxMD5Crypted;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.MemoEdit tbxMD5Origin;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMD5Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMD5Charset;
        private System.Windows.Forms.Button btnMD5Crypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.MemoEdit tbxMDSalt;
    }
}