using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace MainluWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webView21.Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var url = webView21.Source = new Uri("https://sites.google.com/view/alsoftp/inicio");
            toolStripTextBox1.Text = url.AbsoluteUri.ToString();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://sites.google.com/view/alsoftp/inicio");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.bing.com/search?q=" + toolStripTextBox1.ToString());
            if (toolStripTextBox1.ToolTipText == "")
            {
                webView21.Source = new Uri("https://sites.google.com/view/alsoftp/inicio");
            }
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            //There's nothing to code here.
        }
    }
}
