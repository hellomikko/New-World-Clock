using System;
using System.Windows.Forms;

namespace NWClock
{
    public partial class NWClock : Form
    {
        public NWClock()
        {
            InitializeComponent();
        }

        public string Url;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           //nothing here to see or do so... moving on down below
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
            
        }

        private void closewindow_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/icueMike/New-World-Clock/issues/new/choose");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/Pv69e6BkDE");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/icueMike/New-World-Clock");
        }
    }
}
