using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NativeWebTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "/webview/index.html");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (webBrowser1.DocumentTitle.Contains("close"))
            {
                this.Close();
            }
        }
    }
}
