using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NukedStresser
{
    public partial class iplookup : Form
    {

        WebClient wc = new WebClient();
        public iplookup()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void iplookup_Load(object sender, EventArgs e)
        {
            lookupthisbitch();
        }

        private void lookupthisbitch()
        {

            string hostname = wc.DownloadString("http://ip-api.com/line/" + Form1.iptext + "?fields=4096");
            string isp = wc.DownloadString("http://ip-api.com/line/" + Form1.iptext + "?fields=512");
            string country = wc.DownloadString("http://ip-api.com/line/" + Form1.iptext + "?fields=1");
            string state = wc.DownloadString("http://ip-api.com/line/" + Form1.iptext + "?fields=8");
            string city = wc.DownloadString("http://ip-api.com/line/" + Form1.iptext + "?fields=16");
            label2.Text = ("IP : " + Form1.iptext + "\n" + "\n" + "Hostname : " + hostname + "\n" + "ISP : " + isp + "\n" + "Country : " + country + "\n" + "State : " + state + "\n" + "City : " + city);

        }
    }
}
