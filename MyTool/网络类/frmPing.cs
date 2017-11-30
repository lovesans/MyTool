using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;

namespace MyTool
{
    public partial class frmPing : Form
    {
        public frmPing()
        {
            InitializeComponent();
        }
        private bool isStop;
        private bool stoped;

        private string _address;
        private int _delay;
        private int _timeOut;
        private int _ttl;
        private int _dataLength;
        private bool _fragment;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!stoped)
                    throw new Exception("正在执行PING操作，请先结束后再开始！");
                if(!isStop)
                    throw new Exception("正在执行PING操作，请先结束后再开始！");                
                if(string.IsNullOrEmpty(tbxAddr.Text))
                    throw new Exception("服务器地址必须填写！");
                _address = tbxAddr.Text;
                _delay = (int)tbxDelay.Value;
                _timeOut = (int)tbxTimeOut.Value;
                _ttl = (int)tbxTTL.Value;
                _dataLength = (int)tbxLength.Value;
                _fragment = chkFregment.Checked;
                isStop = false;
                stoped = false;
                memoEdit1.Text = "";
                Task tsk = new Task(run);
                tsk.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void run()
        {
            while(!isStop)
            {
                try
                {
                    Ping ping = new Ping();
                    PingOptions option = new PingOptions(_ttl, _fragment);
                    option.Ttl = _ttl;
                    byte[] buffer = new byte[_dataLength];
                    PingReply reply = ping.Send(_address, _timeOut, buffer, option);
                    string retStr = "";
                    if(reply.Status ==IPStatus.Success)
                    {
                        retStr = string.Format("Server={0}  SendData={5}Bytes    RecvData={1}Bytes  Time={2}ms NotFragment={3}  TTL={4}", reply.Address, reply.Buffer.Length, reply.RoundtripTime, reply.Options.DontFragment, reply.Options.Ttl,buffer.Length);
                    }
                    else
                    {
                        retStr = "失败：" + reply.Status.ToString();
                    }
                    Invoke(new MethodInvoker(() => memoEdit1.Text += "\r\n" + retStr));
                }
                catch (Exception)
                {

                }
                Thread.Sleep(_delay);
            }
            stoped = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            isStop = true;
        }

        private void frmPing_Load(object sender, EventArgs e)
        {
            isStop = true;
            stoped = true;
        }
    }
}
