using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNoodle
{
    public partial class Log : Form
    {
        Form1 autism;
        public Log(Form1 f)
        {
            autism = f;
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_Closing);
            
        }
        private void Log_Closing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            autism.button2.Text = "Open log";

        }
        public void WriteLine(string s)
        {
            Console.WriteLine(s);
            if (logbox.InvokeRequired)
            {
                logbox.Invoke(new Action(() => logbox.Text += s + Environment.NewLine));
                return;
            }
            
            logbox.Text += s + Environment.NewLine;
        }

    }
}
