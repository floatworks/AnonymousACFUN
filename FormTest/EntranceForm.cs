using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using AnonymousACfun.Library;
using System.Xml;

namespace FormTest
{
    public partial class EntranceForm : Form
    {
        public EntranceForm()
        {
            InitializeComponent();
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            BindEvents();
        }

        private void BindEvents()
        {
            btn_Submit.Click += btn_Submit_Click;
        }

        void btn_Submit_Click(object sender, EventArgs e)
        {
            btn_Submit.Click -= btn_Submit_Click;
            try
            {
                Submit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.InnerException);
            }
            btn_Submit.Click += btn_Submit_Click;
        }

        private void Submit()
        {
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Accept", "xml");
                client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DownloadStringCompleted);
                client.DownloadStringAsync(new Uri(ConstValue.urlPrefix + tb_Url.Text));
            }
        }

        void DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                tb_Response.Text = XmlFormat(e.Result);
                if (e.Error != null)
                {
                    MessageBox.Show(e.Error.Message + "\r\n" + e.Error.InnerException);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.InnerException);
            }
        }

        private string XmlFormat(string p)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(p);
            StringBuilder sb = new StringBuilder();
            XmlWriter xw = XmlWriter.Create(sb, new XmlWriterSettings() { Indent = true });
            xmlDoc.WriteTo(xw);
            xw.Flush();
            return sb.ToString();
        }
    }
}
