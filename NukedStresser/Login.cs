using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySeal;

namespace NukedStresser
{
    public partial class Login : Form
    {
        public Login()
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
        }

        Thread nigga;

        private void logInLogButton1_Click(object sender, EventArgs e)
        {
            string user = "Username";
            string pass = "Password";
            if (usernamelogin.Text == user || passwordlogin.Text == pass)
            {
                MessageBox.Show("Please enter your given login details", "Shadow Stresser", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Are you connected to the internet ?", "Shadow Stresser");
                }
            }
        }

        private void opennewform1(object obj)
        {
            Application.Run(new Form1());
        }

        private void logInLogButton2_Click(object sender, EventArgs e)
        {
            string user = "Aqua";
            string pass = "Aqua";
            string email = "aquarium@putin.ru";
            string token = "AQUA";
            if (usernamereg.Text == user || passwordreg.Text == pass || emailreg.Text == email || tokenreg.Text == token)
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                try
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Are you connected to the internet ?", "Shadow Stresser");
                }
            }
        }

        private void usernamelogin_Enter(object sender, EventArgs e)
        {
            if (usernamelogin.Text == "Username")
            {
                usernamelogin.Text = "";
                usernamelogin.ForeColor = Color.Yellow;
            }
        }

        private void usernamelogin_Leave(object sender, EventArgs e)
        {
            if (usernamelogin.Text == "")
            {
                usernamelogin.Text = "Username";
                usernamelogin.ForeColor = Color.Silver;
            }
        }

        private void passwordlogin_Enter(object sender, EventArgs e)
        {
            if (passwordlogin.Text == "Password")
            {
                passwordlogin.Text = "";
                passwordlogin.ForeColor = Color.Yellow;
            }
        }
        private void passwordlogin_Leave(object sender, EventArgs e)
        {
            if (passwordlogin.Text == "")
            {
                passwordlogin.Text = "Password";
                passwordlogin.ForeColor = Color.Silver;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
