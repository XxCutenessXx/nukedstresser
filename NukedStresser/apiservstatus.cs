using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NukedStresser
{
    public partial class apiservstatus : Form
    {
        public apiservstatus()
        {
            InitializeComponent();
        }
        string apiserv1 = "0.0.0.0";
        string apiserv2 = "0.0.0.0";
        string apiserv3 = "0.0.0.0"; 
        string apiserv4 = "0.0.0.0";
        string apiserv5 = "0.0.0.0";
        private void timer1_Tick(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingReply reply = p.Send(apiserv1);
            if (reply.Status.ToString() == "Success")
            {
                label9.Text = "UP";
                label9.ForeColor = Color.Lime;
            }
            else
            {
                label9.Text = "DOWN";
                label9.ForeColor = Color.Red;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingReply reply = p.Send(apiserv2);
            if (reply.Status.ToString() == "Success")
            {
                label10.Text = "UP";
                label10.ForeColor = Color.Lime;
            }
            else
            {
                label10.Text = "DOWN";
                label10.ForeColor = Color.Red;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingReply reply = p.Send(apiserv3);
            if (reply.Status.ToString() == "Success")
            {
                label11.Text = "UP";
                label11.ForeColor = Color.Lime;
            }
            else
            {
                label11.Text = "DOWN";
                label11.ForeColor = Color.Red;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingReply reply = p.Send(apiserv4);
            if (reply.Status.ToString() == "Success")
            {
                label12.Text = "UP";
                label12.ForeColor = Color.Lime;
            }
            else
            {
                label12.Text = "DOWN";
                label12.ForeColor = Color.Red;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingReply reply = p.Send(apiserv5);
            if (reply.Status.ToString() == "Success")
            {
                label13.Text = "UP";
                label13.ForeColor = Color.Lime;
            }
            else
            {
                label13.Text = "DOWN";
                label13.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
