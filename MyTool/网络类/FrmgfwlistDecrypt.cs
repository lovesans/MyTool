using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyTool
{
    public partial class FrmgfwlistDecrypt : Form
    {
        public FrmgfwlistDecrypt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lines = memoEdit1.Lines;
            List<string> res = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                string tmpDomain = lines[i].Replace("!", "").Replace("|", "").Replace("http://", "").Replace("https://", "").Replace("~", "").Replace("@", "");
                if (tmpDomain.IndexOf("Whitelist") >= 0)
                {
                    break;
                }
                if (IsDomain(tmpDomain))
                {
                    List<string> tmpList = MatchsDomain(tmpDomain);
                    if (tmpList != null && tmpList.Count > 0)
                    {
                        for (int j = 0; j < tmpList.Count; j++)
                        {
                            if (res.IndexOf(tmpList[j]) < 0)
                            {
                                res.Add(checkBox1.Checked ? string.Format("id={0} state=up comment= domain={1} interface={2}", res.Count + 1, tmpList[j],tbxInterface.Text) : tmpList[j]);
                            }
                        }
                    }
                }
            }
            string googleSuffix = "ac|ad|ae|af|al|am|as|at|az|ba|be|bf|bg|bi|bj|bs|bt|by|ca|cat|cd|cf|cg|ch|ci|cl|cm|co.ao|co.bw|co.ck|co.cr|co.id|co.il|co.in|co.jp|co.ke|co.kr|co.ls|co.ma|com|com.af|com.ag|com.ai|com.ar|com.au|com.bd|com.bh|com.bn|com.bo|com.br|com.bz|com.co|com.cu|com.cy|com.do|com.ec|com.eg|com.et|com.fj|com.gh|com.gi|com.gt|com.hk|com.jm|com.kh|com.kw|com.lb|com.ly|com.mm|com.mt|com.mx|com.my|com.na|com.nf|com.ng|com.ni|com.np|com.om|com.pa|com.pe|com.pg|com.ph|com.pk|com.pr|com.py|com.qa|com.sa|com.sb|com.sg|com.sl|com.sv|com.tj|com.tr|com.tw|com.ua|com.uy|com.vc|com.vn|co.mz|co.nz|co.th|co.tz|co.ug|co.uk|co.uz|co.ve|co.vi|co.za|co.zm|co.zw|cv|cz|de|dj|dk|dm|dz|ee|es|eu|fi|fm|fr|ga|ge|gg|gl|gm|gp|gr|gy|hk|hn|hr|ht|hu|ie|im|iq|is|it|it.ao|je|jo|kg|ki|kz|la|li|lk|lt|lu|lv|md|me|mg|mk|ml|mn|ms|mu|mv|mw|mx|ne|nl|no|nr|nu|org|pl|pn|ps|pt|ro|rs|ru|rw|sc|se|sh|si|sk|sm|sn|so|sr|st|td|tg|tk|tl|tm|tn|to|tt|us|vg|vn|vu|ws";
            var gsuf = googleSuffix.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < gsuf.Length; i++)
            {
                string tmpStr = "google." + gsuf[i];
                if (res.IndexOf(tmpStr) < 1)
                {
                    res.Add(checkBox1.Checked ? string.Format("id={0} state=up comment= domain={1} interface={2}", res.Count + 1, tmpStr,tbxInterface.Text) : tmpStr);
                }
            }
            memoEdit2.Lines = res.ToArray();
        }
        public static bool IsDomain(string str)
        {
            string pattern = @"^[a-zA-Z0-9\.][-a-zA-Z0-9]{0,62}(\.[a-zA-Z0-9][-a-zA-Z0-9]{0,62})+$";
            Regex reg = new Regex(pattern);
            if (string.IsNullOrEmpty(str))
                return false;
            return reg.IsMatch(str);
        }

        public static List<string> MatchsDomain(string input)
        {
            string pattern = @"[a-zA-Z0-9][-a-zA-Z0-9]{0,62}(\.[a-zA-Z0-9][-a-zA-Z0-9]{0,62})+";
            List<string> list = new List<string>();
            MatchCollection collection = Regex.Matches(input, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            foreach (Match item in collection)
            {
                if (item.Success)
                {
                    list.Add(item.Value);
                }
            }
            return list;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                memoEdit1.Text = Encoding.ASCII.GetString(Convert.FromBase64String(memoEdit1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmPacDecrypt_Resize(object sender, EventArgs e)
        {
            groupBox1.Width = (int)(Width / 2 - 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Text = "正在下载...";
                System.Threading.Tasks.Task tsk = new System.Threading.Tasks.Task(downList);
                tsk.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void downList()
        {
            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();
                string res = wc.DownloadString("https://raw.githubusercontent.com/gfwlist/gfwlist/master/gfwlist.txt");
                Invoke(new MethodInvoker(() =>
                {
                    memoEdit1.Text = res;
                    button2.Text = "下载列表";
                }
                ));
            }
            catch (Exception)
            {
                Invoke(new MethodInvoker(() =>
                {
                    memoEdit1.Text = "";
                    button2.Text = "下载列表";
                }
                ));
            }
        }
    }
}
