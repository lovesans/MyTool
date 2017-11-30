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
                if (string.IsNullOrEmpty(cbxMD5Type.Text))
                    throw new Exception("必须选择加密方式！");
                MD5CrypType mc = (MD5CrypType)Enum.Parse(typeof(MD5CrypType), cbxMD5Type.Text.Replace("(", "").Replace(")", "").Replace("$", "dollar").Replace(".", "dot"));
                return mc;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnMD5Crypt_Click(object sender, EventArgs e)
        {
            try
            {
                tbxMD5Crypted.Text = "";
                string pass = CryptUtil.MD5Crypt(tbxMD5Origin.Text, GetMD5CrypType(), tbxMDSalt.Text, radioGroup1.SelectedIndex, getEncoding(cbxMD5Charset));
                tbxMD5Crypted.Text = pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        #region SHA
        private SHACrypType getShaType()
        {
            try
            {
                if (string.IsNullOrEmpty(cbxSHAType.Text))
                    throw new Exception("必须选择加密方式！");
                return (SHACrypType)Enum.Parse(typeof(SHACrypType), cbxSHAType.Text.Replace("(", "").Replace(")", "").Replace("$", "dollar").Replace(".", "dot"));
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                tbxSHACrypted.Text = "";
                string txt = tbxSHAOrigin.Text;
                string salt = tbxSHASalt.Text;
                string pass = CryptUtil.SHAEncrypt(txt, salt, getShaType(), getEncoding(cbxSHACharset));
                tbxSHACrypted.Text = pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region DES
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(tbxDESOrigin.Text))
                    throw new Exception("原文不能为空！");
                tbxDESCrypted.Text = "";
                string pass = CryptUtil.DESEncrypt(tbxDESOrigin.Text, tbxDESKey.Text, tbxDESKeyIV.Text, cbxDESMode.Text, cbxDESPadding.Text, getEncoding(cbxDESCharset));
                tbxDESCrypted.Text = pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(tbxDESCrypted.Text))
                    throw new Exception("密文不能为空！");
                tbxDESOrigin.Text = "";
                string org = CryptUtil.DESDecrypt(tbxDESCrypted.Text, tbxDESKey.Text, tbxDESKeyIV.Text, cbxDESMode.Text, cbxDESPadding.Text, getEncoding(cbxDESCharset));
                tbxDESOrigin.Text = org;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        
    }
}
