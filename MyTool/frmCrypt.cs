using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyTool
{
    public partial class frmCrypt : Form
    {
        public frmCrypt()
        {
            InitializeComponent();
        }
        #region 获取选择的编码
        private Encoding getEncoding(ComboBox cbxCharset)
        {
            switch (cbxCharset.Text)
            {
                case "UTF-8":
                    return Encoding.UTF8;
                case "UTF-7":
                    return Encoding.UTF7;
                case "UTF-32":
                    return Encoding.UTF32;
                case "UNICODE":
                    return Encoding.Unicode;
                case "ASCII":
                    return Encoding.ASCII;
                case "GB2312":
                    return Encoding.GetEncoding("GB2312");
                case "GB18030":
                    return Encoding.GetEncoding("GB18030");
                case "GBK":
                    return Encoding.GetEncoding("GBK");
                default:
                    return Encoding.UTF8;
            }
        }
        #endregion
        #region BASE64

        private void tbxBaseEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbxBaseOrigin.Text))
                    throw new Exception("原文必须填写！");
                tbxBaseCrypted.Text = "";
                string pass = CryptUtil.Base64Encrypt(tbxBaseOrigin.Text, getEncoding(cbxBaseCharset), chkBaseOption.Checked ? Base64FormattingOptions.InsertLineBreaks : Base64FormattingOptions.None);
                tbxBaseCrypted.Text = pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbxBaseDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbxBaseCrypted.Text))
                    throw new Exception("密文必须填写！");
                string txt = CryptUtil.Base64Decrypt(tbxBaseCrypted.Text, getEncoding(cbxBaseCharset));
                tbxBaseOrigin.Text = txt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region MD5
        private MD5CrypType GetMD5CrypType()
        {
            try
            {
                if(string.IsNullOrEmpty( cbxMD5Type.Text))
                    throw new Exception("必须选择加密方式！");
                MD5CrypType mc = (MD5CrypType)Enum.Parse(typeof(MD5CrypType), cbxMD5Type.Text.Replace("(","").Replace(")","").Replace("$","dollar").Replace(".","dot"));
                return mc;
            }
            catch (Exception )
            {
                throw;
            }
        }
#endregion


    }
}
