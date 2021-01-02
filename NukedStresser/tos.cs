using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NukedStresser
{
    public partial class tos : Form
    {
        public tos()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0); //closes app
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
