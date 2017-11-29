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
        public static string MD32Crypt(string txt, Encoding sEncode = null)
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
        /// <summary>
        /// 带盐32位MD5加密
        /// </summary>
        /// <param name="txt">原文</param>
        /// <param name="sault">盐</param>
        /// <param name="sEncode">编码</param>
        /// <returns></returns>
        public static string MD32Crypt(string txt, string sault, Encoding sEncode = null)
        {
            try
            {
                string s = MD32Crypt(txt, sEncode) + sault;
                s = MD32Crypt(s);
                return s;
            }
            catch (Exception)
            {
                throw;
            }
        }
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
