using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyTool
{
    public partial class frmIPSeprate : Form
    {
        public frmIPSeprate()
        {
            InitializeComponent();
        }
        #region 下载国家列表
        private void getCountryList()
        {
            try
            {
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                string body = wc.DownloadString("http://ipblock.chacuo.net/");
                if (string.IsNullOrEmpty(body))
                    throw new Exception("下载失败！");
                string pattern = "<li><a (.*)href='http://ipblock.chacuo.net/view/(.*)' py=\"(.*)\">(.*)</a></li>";
                var match = Regex.Matches(body, pattern);
                DataTable dt = new DataTable();
                dt.Columns.Add("tag");
                dt.Columns.Add("name");
                foreach (Match item in match)
                {
                    DataRow dr = dt.NewRow();
                    dr["tag"] = item.Groups[2].ToString();
                    dr["name"] = item.Groups[4].ToString();
                    dt.Rows.Add(dr);
                }
                dt.DefaultView.Sort = "name asc";
                cbxCountry.DataSource = dt;
                cbxCountry.DisplayMember = "name";
                cbxCountry.ValueMember = "tag";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region 下载指定国家IP库
        private void getIPList()
        {
            try
            {
                if (string.IsNullOrEmpty(cbxCountry.Text))
                    throw new Exception("必须选择国家！");
                string cTag = cbxCountry.SelectedValue.ToString();
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                wc.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:57.0) Gecko/20100101 Firefox/57.0";
                wc.Headers[HttpRequestHeader.Accept] = "*/*";
                string s= wc.DownloadString("http://ipblock.chacuo.net/view/" + cTag);                
                wc.Headers[HttpRequestHeader.Referer] = "http://ipblock.chacuo.net/view/" + cTag;
               string body= wc.DownloadString("http://ipblock.chacuo.net/down/t_txt=" + cTag); 
                if (string.IsNullOrEmpty(body))
                    throw new Exception("下载失败！");
                tbxList.Text = body.Replace("<pre>\r\n", "").Replace("\r\n</pre>", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = tbxList.Lines;
                List<string> res = new List<string>();
                for (int i = 0; i < lines.Length; i++)
                {
                    if (!string.IsNullOrEmpty(lines[i].Trim()))
                    {
                        string[] tmp = lines[i].Split('	');
                        if (null == tmp || tmp.Length != 4)
                        {
                            continue;
                        }
                        res.Add(tmp[Convert.ToInt32(cbxColumn.Text) - 1]);
                    }
                }
                tbxResualt.Lines = res.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getCountryList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getIPList();
        }

        private void frmIPSeprate_Load(object sender, EventArgs e)
        {
            cbxColumn.SelectedIndex = 2;
        }
    }
}
