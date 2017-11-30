using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MyTool
{
    public static class CryptUtil
    {
        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="txt">原文</param>
        /// <param name="sEncode">编码</param>
        /// <returns></returns>
        private static string MD32Crypt(string txt, Encoding sEncode = null)
        {
            try
            {
                sEncode = null == sEncode ? Encoding.UTF8 : sEncode;
                byte[] orgByte = sEncode.GetBytes(txt);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] toByte = md5.ComputeHash(orgByte);
                string retPwd = "";
                for (int i = 0; i < toByte.Length; i++)
                {
                    retPwd += toByte[i].ToString("x2");
                }
                return retPwd;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string  MD5Crypt(string txt,MD5CrypType mType,string salt,int outType=0,Encoding encoding=null)
        {
            try
            {
                encoding = encoding ?? Encoding.UTF8;
                string pass = "";
                switch (mType)
                {
                    case MD5CrypType.md5pass:
                        pass = MD32Crypt(txt,encoding);
                        break;
                    case MD5CrypType.md5md5pass:
                        pass = MD32Crypt(MD32Crypt(txt,encoding),encoding);
                        break;
                    case MD5CrypType.md5dollarpassdotdollarsalt:
                        pass = MD32Crypt(txt + salt,encoding);
                        break;
                    case MD5CrypType.md5dollarsaltdotdollarpass:
                        pass = MD32Crypt(salt + pass, encoding);
                        break;
                    case MD5CrypType.md5md5dollarpassdotdollarsalt:
                        pass = MD32Crypt(MD32Crypt(txt, encoding) + salt, encoding);
                        break;
                    case MD5CrypType.md5md5dollarsaltdotdollarpass:
                        pass = MD32Crypt(MD32Crypt(salt, encoding) + txt, encoding);
                        break;
                    case MD5CrypType.md5dollarsaltdotdollarpassdotdollarsalt:
                        pass = MD32Crypt(salt + txt + salt, encoding);
                        break;
                    case MD5CrypType.md5dollarsaltdotmd5dollarpass:
                        pass = MD32Crypt(salt + MD32Crypt(txt, encoding), encoding);
                        break;
                    case MD5CrypType.md5md5dollarpassdotmd5dollarsalt:
                        pass = MD32Crypt(MD32Crypt(txt, encoding) + MD32Crypt(salt, encoding), encoding);
                        break;
                    case MD5CrypType.md5md5dollarsaltdotmd5dollarpass:
                        pass = MD32Crypt(MD32Crypt(salt, encoding) + MD32Crypt(txt, encoding), encoding);
                        break;
                    default:
                        pass = "";
                        break;
                }
                switch (outType)
                {
                    case 0:
                        //32大
                        pass = pass.ToUpper();
                        break;
                    case 1:
                        //32小
                        pass = pass.ToLower();
                        break;
                    case 2:
                        //16大
                        pass = pass.Substring(8, 16).ToUpper();
                        break;
                    case 3:
                        //16小
                        pass = pass.Substring(8, 16).ToLower();
                        break;
                    case 4:
                        //base64
                        pass = pass.ToUpper();
                        pass = Convert.ToBase64String(encoding.GetBytes(pass));
                        break;
                    default:
                        break;
                }
                return pass;
                
            }
            catch (Exception)
            {

                throw;
            }
        }
#region SHA
        private static string SHA1Crypt(string txt,Encoding encoding=null)
        {
            try
            {
                encoding = encoding ?? Encoding.UTF8;
                if(string.IsNullOrEmpty(txt))
                    throw new Exception("原文不能为空！");
                SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
                byte[] org = encoding.GetBytes(txt);
                byte[] output = sha1.ComputeHash(org);
                string retStr = "";
                for (int i = 0; i < output.Length; i++)
                {
                    retStr += output[i].ToString("x2");
                }
                return retStr;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static string SHA256Crypt(string txt, Encoding encoding = null)
        {
            try
            {
                encoding = encoding ?? Encoding.UTF8;
                if (string.IsNullOrEmpty(txt))
                    throw new Exception("原文不能为空！");
                SHA256CryptoServiceProvider sha = new SHA256CryptoServiceProvider();
                byte[] org = encoding.GetBytes(txt);
                byte[] output = sha.ComputeHash(org);
                string retStr = "";
                for (int i = 0; i < output.Length; i++)
                {
                    retStr += output[i].ToString("x2");
                }
                return retStr;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static string SHA384Crypt(string txt, Encoding encoding = null)
        {
            try
            {
                encoding = encoding ?? Encoding.UTF8;
                if (string.IsNullOrEmpty(txt))
                    throw new Exception("原文不能为空！");
                SHA384CryptoServiceProvider sha = new SHA384CryptoServiceProvider();
                byte[] org = encoding.GetBytes(txt);
                byte[] output = sha.ComputeHash(org);
                string retStr = "";
                for (int i = 0; i < output.Length; i++)
                {
                    retStr += output[i].ToString("x2");
                }
                return retStr;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static string SHA512Crypt(string txt, Encoding encoding = null)
        {
            try
            {
                encoding = encoding ?? Encoding.UTF8;
                if (string.IsNullOrEmpty(txt))
                    throw new Exception("原文不能为空！");
                SHA512CryptoServiceProvider sha = new SHA512CryptoServiceProvider();
                byte[] org = encoding.GetBytes(txt);
                byte[] output = sha.ComputeHash(org);
                string retStr = "";
                for (int i = 0; i < output.Length; i++)
                {
                    retStr += output[i].ToString("x2");
                }
                return retStr;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static string SHAEncrypt(string txt,string salt,SHACrypType cType,Encoding encoding=null)
        {
            try
            {
                encoding = encoding ?? Encoding.UTF8;
                if(string.IsNullOrEmpty(txt))
                    throw new Exception("原文不能为空！");
                string pass = "";
                switch (cType)
                {
                    case SHACrypType.sha1dollarpass:
                        pass = SHA1Crypt(txt, encoding);
                        break;
                    case SHACrypType.sha1dollarpassdotdollarsalt:
                        pass = SHA1Crypt(txt + salt, encoding);
                        break;
                    case SHACrypType.sha1dollarsaltdotdollarpass:
                        pass = SHA1Crypt(salt + txt, encoding);
                        break;
                    case SHACrypType.sha256dollarpass:
                        pass = SHA256Crypt(txt, encoding);
                        break;
                    case SHACrypType.sha256dollarpassdotdollarsalt:
                        pass = SHA256Crypt(txt + salt, encoding);
                        break;
                    case SHACrypType.sha256dollarsaltdotdollarpass:
                        pass = SHA256Crypt(salt + txt, encoding);
                        break;
                    case SHACrypType.sha384dollarpass:
                        pass = SHA384Crypt(txt, encoding);
                        break;
                    case SHACrypType.sha384dollarpassdotdollarsalt:
                        pass = SHA384Crypt(txt + salt, encoding);
                        break;
                    case SHACrypType.sha384dollarsaltdotdollarpass:
                        pass = SHA384Crypt(salt + txt, encoding);
                        break;
                    case SHACrypType.sha512dollarpass:
                        pass = SHA512Crypt(txt, encoding);
                        break;
                    case SHACrypType.sha512dollarpassdotdollarsalt:
                        pass = SHA512Crypt(txt + salt, encoding);
                        break;
                    case SHACrypType.sha512dollarsaltdotdollarpass:
                        pass = SHA512Crypt(salt + txt, encoding);
                        break;
                    default:
                        break;
                }
                return pass;
            }
            catch (Exception)
            {

                throw;
            }
        }
#endregion
        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="txt">原文</param>
        /// <param name="key">密码</param>
        /// <param name="keyIV">偏移</param>
        /// <param name="sEncode">编码</param>
        /// <returns></returns>
        public static string DESEncrypt(string txt, string key, string keyIV, Encoding sEncode = null)
        {
            try
            {
                sEncode = null == sEncode ? Encoding.UTF8 : sEncode;
                if (key.Length < 8)
                {
                    for (int i = 0; key.Length < 8; i++)
                    {
                        key += "0";
                    }
                }
                if (key.Length > 8)
                    key = key.Substring(0, 8);

                if (keyIV.Length < 8)
                {
                    for (int i = 0; keyIV.Length < 8; i++)
                    {
                        keyIV += "0";
                    }
                }
                if (keyIV.Length > 8)
                    keyIV = keyIV.Substring(0, 8);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider(); //加解密对象
                byte[] orgByte = sEncode.GetBytes(txt);//原文
                des.Key = sEncode.GetBytes(key);//密钥
                if (string.IsNullOrEmpty(keyIV)) //偏移量
                    des.IV = new byte[8];
                else
                    des.IV = sEncode.GetBytes(keyIV);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();//内存流
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);//加解密流
                cs.Write(orgByte, 0, orgByte.Length);//加密
                cs.FlushFinalBlock();
                cs.Close();
                StringBuilder sb = new StringBuilder();
                //循环写出16进制文本
                foreach (byte b in ms.ToArray())
                    sb.AppendFormat("{0:X2}", b);
                ms.Close();
                ms = null;
                return sb.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="pass">密文</param>
        /// <param name="key">密码</param>
        /// <param name="keyIV">偏移</param>
        /// <param name="sEncode">编码</param>
        /// <returns></returns>
        public static string DESDecrypt(string pass, string key, string keyIV, Encoding sEncode = null)
        {
            try
            {
                sEncode = null == sEncode ? Encoding.UTF8 : sEncode;
                if (key.Length < 8)
                {
                    for (int i = 0; key.Length < 8; i++)
                    {
                        key += "0";
                    }
                }
                if (key.Length > 8)
                    key = key.Substring(0, 8);

                if (keyIV.Length < 8)
                {
                    for (int i = 0; keyIV.Length < 8; i++)
                    {
                        keyIV += "0";
                    }
                }
                if (keyIV.Length > 8)
                    keyIV = keyIV.Substring(0, 8);

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] orgByte = new byte[pass.Length / 2];
                for (int i = 0; i < pass.Length / 2; i++)
                    orgByte[i] = (byte)(Convert.ToInt32(pass.Substring(i * 2, 2), 16));
                des.Key = sEncode.GetBytes(key);
                des.IV = sEncode.GetBytes(keyIV);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(orgByte, 0, orgByte.Length);
                cs.FlushFinalBlock();
                cs.Close();
                string retstr = sEncode.GetString(ms.ToArray());
                ms.Close();
                ms = null;
                return retstr;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// BASE64编码
        /// </summary>
        /// <param name="txt">原文</param>
        /// <param name="encoding">编码</param>
        /// <param name="option">是否加换行符</param>
        /// <returns></returns>
        public static string Base64Encrypt(string txt,Encoding encoding=null, Base64FormattingOptions option= Base64FormattingOptions.None)
        {
            try
            {
                encoding= encoding ?? Encoding.UTF8;
                if(string.IsNullOrEmpty(txt))
                    throw new Exception("原文不能为空！");
                byte[] buffer = encoding.GetBytes(txt);
                return Convert.ToBase64String(buffer, option);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// BASE64解码
        /// </summary>
        /// <param name="pass">密文</param>
        /// <param name="encoding">编码</param>
        /// <returns></returns>
        public static string Base64Decrypt(string pass,Encoding encoding)
        {
            try
            {
                encoding = encoding ?? Encoding.UTF8;
                if(string.IsNullOrEmpty(pass))
                    throw new Exception("密文不能为空！");
                byte[] buffer= Convert.FromBase64String(pass);
                return encoding.GetString(buffer);                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
