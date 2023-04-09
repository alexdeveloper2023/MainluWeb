using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

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
            webView21.Source = new Uri("https://www.google.com");
            if (googleToolStripMenuItem.Checked == true)
            {
                webView21.CoreWebView2.Navigate("https://www.google.com/search?q=" + toolStripTextBox1.Text.ToString());
            }

            if (bingToolStripMenuItem.Checked == true)
            {
                webView21.CoreWebView2.Navigate("https://www.bing.com/search?q=" + toolStripTextBox1.Text.ToString());
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (googleToolStripMenuItem.Checked == true)
            {
                webView21.CoreWebView2.Navigate("https://www.google.com/search?q=" + toolStripTextBox1.Text.ToString());
            }

            if (bingToolStripMenuItem.Checked == true)
            {
                webView21.CoreWebView2.Navigate("https://www.bing.com/search?q=" + toolStripTextBox1.Text.ToString());
            }
        }

        private void toolStripButton5_ButtonClick(object sender, EventArgs e)
        {

            if (googleToolStripMenuItem.Checked == true)
            {
                webView21.CoreWebView2.Navigate("https://www.google.com/search?q=" + toolStripTextBox1.Text.ToString());
            }

            if (bingToolStripMenuItem.Checked == true)
            {
                webView21.CoreWebView2.Navigate("https://www.bing.com/search?q=" + toolStripTextBox1.Text.ToString());
            }
            if (toolStripTextBox1.Text == string.Empty)
            {
                
            }
        }

        private void bingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bingToolStripMenuItem.Checked = true;
            if (bingToolStripMenuItem.Checked)
            {
                googleToolStripMenuItem.Checked = false;
            }
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            googleToolStripMenuItem.Checked = true;
            if (googleToolStripMenuItem.Checked)
            {
                bingToolStripMenuItem.Checked = false;
            }
        }

        private void webView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            var title = webView21.CoreWebView2.DocumentTitle;
            this.Text = title + " - Mainlu";
            toolStripTextBox1.Text = webView21.CoreWebView2.Source;

            if (toolStripTextBox1.Text == string.Empty)
            {
                
            }

        }
    }
}
