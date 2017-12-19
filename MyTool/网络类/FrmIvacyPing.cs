using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MyTool
{
    public partial class FrmIvacyPing : Form
    {
        public FrmIvacyPing()
        {
            InitializeComponent();
        }
        private DataTable dt;
        private Queue<PServerModel> pQueue = new Queue<PServerModel>();
        private Queue<PServerModel> rQueue = new Queue<PServerModel>();
        private void FrmPing_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("地址");
            dt.Columns.Add("延迟", Type.GetType("System.Int32"));
            dt.Columns["延迟"].DefaultValue = 9999;
            dt.Columns.Add("PING次数",Type.GetType("System.Int32"));
            dt.Columns["PING次数"].DefaultValue = 0;
            dt.Columns.Add("成功次数", Type.GetType("System.Int32"));
            dt.Columns["成功次数"].DefaultValue = 0;
            dt.Columns.Add("失败次数", Type.GetType("System.Int32"));
            dt.Columns["失败次数"].DefaultValue = 0;
            dt.Columns.Add("最后信息");
            DataRow dr = dt.NewRow();
            dr["地址"] = "usla1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "ussa1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "usny1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vleu-usny1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlbr-usvc1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlsa-ussf1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "usnj1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "usga1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "usil1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "uswdc1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "usfl1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlap-usga1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlap-usil1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "usca1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "ukm1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "caq1.ivacy.net";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "cav1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "de1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-de1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "nl1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-se1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "se1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "ch1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-pa1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-ru.ivacy.net";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "ru1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "my-kl1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "my1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "sg1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "lu1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "lu-st1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-au1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "au-bn1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "tr1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-tr1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "fr1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "br1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-cr1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-eg1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "lv1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "hk1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "hkf1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-it1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "it1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "bg1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "za1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlbr-cl1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "idn1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "tw1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "kr1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "kr-se1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "cn-hn1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "cn-hn2.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "cn.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "cz1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "pl1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vleu-dk1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "fi1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-jo1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-kw1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "bn1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vleu-in1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "gh1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "ng1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "pe1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "co1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "sa1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "ve1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "sc1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "ke1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "pk1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "mx1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vleu-be1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "Dubai	ae1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "nz1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "vlus-nz1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "at1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            //dr["地址"] = "vlus-jp1.dns2use.com";
            //dt.Rows.Add(dr);
            //dr = dt.NewRow();
            dr["地址"] = "172.111.189.1";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "172.94.56.2";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "172.94.27.130";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "103.46.141.189";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "172.94.27.2";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "jp1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "es1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["地址"] = "no1.dns2use.com";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dataGridView1.DataSource = dt;
        }
        private bool stopPing;
        private void button1_Click(object sender, EventArgs e)
        {
            stopPing = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PServerModel psm = new PServerModel
                {
                    Delay = 0,
                    Index = i,
                    Success = false
                };
                pQueue.Enqueue(psm);
            }
            for (int i = 0; i < 10; i++)
            {
                Task tsk = new Task(run);
                tsk.Start();
            }
            Task stsk = new Task(check);
            stsk.Start();
            button1.Enabled = false;
        }
        private void check()
        {
            while (!stopPing)
            {
                PServerModel psm = null;
                try
                {
                    if (rQueue.Count > 0)
                    {
                        psm = rQueue.Dequeue();
                        if (psm.Success)
                        {
                            dt.Rows[psm.Index]["成功次数"] =dt.Rows[psm.Index].IsNull("成功次数")?1: Convert.ToInt32(dt.Rows[psm.Index]["成功次数"]) + 1;
                        }
                        else
                        {
                            dt.Rows[psm.Index]["失败次数"] = dt.Rows[psm.Index].IsNull("失败次数")?1: Convert.ToInt32(dt.Rows[psm.Index]["失败次数"]) + 1;
                        }
                        dt.Rows[psm.Index]["PING次数"] = dt.Rows[psm.Index].IsNull("PING次数")?1: Convert.ToInt32(dt.Rows[psm.Index]["PING次数"]) + 1;
                        dt.Rows[psm.Index]["最后信息"] = psm.LastMessage;
                        dt.Rows[psm.Index]["延迟"] = psm.Delay;                        
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                    if(pQueue.Count<1)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            PServerModel psma = new PServerModel
                            {
                                Delay = 0,
                                Index = i,
                                Success = false
                            };
                            pQueue.Enqueue(psma);
                        }
                    }

                }
                catch (Exception ex)
                {
                    if (psm != null)
                    {
                        dt.Rows[psm.Index]["最后信息"] = psm.LastMessage+"\r\n" + ex.Message;
                    }
                }
            }

        }
        private void run()
        {

            while (!stopPing)
            {
                PServerModel psm = null;
                try
                {
                    if (pQueue.Count > 0)
                    {
                        psm = pQueue.Dequeue();
                        Ping pSender = new Ping();
                        PingOptions option = new PingOptions();
                        option.DontFragment = true;
                        var ipArray = System.Net.Dns.GetHostAddresses(dt.Rows[psm.Index]["地址"].ToString());
                        if (ipArray != null && ipArray.Length > 0)
                        {
                            string ip = ipArray[0].ToString();                            
                            byte[] buffer = new byte[128];
                            PingReply reply = pSender.Send(ip, 5000, buffer, option);
                            if (reply.Status == IPStatus.Success)
                            {
                                psm.Success = true;
                                psm.Delay = (int)(reply.RoundtripTime);
                                rQueue.Enqueue(psm);                                
                            }
                            else
                            {
                                psm.Success = false;
                                psm.Delay = 9999;
                                psm.LastMessage = "失败：" + reply.Status;
                                rQueue.Enqueue(psm);
                            }
                        }
                        else
                        {
                            psm.Success = false;
                            psm.Delay = 9999;
                            psm.LastMessage = "无法解析";
                            rQueue.Enqueue(psm);
                        }

                    }
                    System.Threading.Thread.Sleep(50);
                }
                catch (Exception ex)
                {
                    if (null == psm)
                        return;
                    psm.Success = false;
                    psm.Delay = 9999;
                    psm.LastMessage = ex.Message;
                    rQueue.Enqueue(psm);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopPing = true;
            button1.Enabled = true;
        }
    }
    public class PServerModel
    {
        public int Index { get; set; }
        public bool Success { get; set; }
        public int Delay { get; set; }
        public string LastMessage { get; set; }
    }
}
