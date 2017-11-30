using DevExpress.XtraTab;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region 标签相关
        private void LoadForm(string caption, Form form)
        {
            try
            {
                foreach (XtraTabPage page in xtraTabControl1.TabPages)
                {
                    if (page.Text == caption)
                    {
                        xtraTabControl1.SelectedTabPage = page;
                        return;
                    }
                }

                XtraTabPage xpage = new XtraTabPage();
                xpage.Name = Guid.NewGuid().ToString();
                xpage.Text = caption;
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;
                xpage.Controls.Add(form);
                xtraTabControl1.TabPages.Add(xpage);
                xtraTabControl1.SelectedTabPage = xpage;
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                var EArg = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;

                string name = EArg.Page.Text;
                foreach (XtraTabPage page in xtraTabControl1.TabPages)
                {
                    if (page.Text == name)
                    {
                        xtraTabControl1.TabPages.Remove(page);
                        page.Dispose();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadForm("gfwlist解析工具", new FrmgfwlistDecrypt());
        }


        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadForm("IP区域列表分解工具", new frmIPSeprate());
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadForm("ivacy服务器PING", new FrmIvacyPing());
        }

        private void navBarItem4_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadForm("加密解密工具", new frmCrypt());
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadForm("PING工具", new frmPing());
        }

        private void barStaticItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.261k.com");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            brsVersion.Caption = Application.ProductVersion;
        }
    }
}
