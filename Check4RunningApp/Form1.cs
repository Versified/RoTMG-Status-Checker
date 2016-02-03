using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Check4RunningApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer m_Timer;

        private void Form1_Load(object sender, EventArgs e)
        {


            RefreshProcesses();

            m_Timer = new System.Windows.Forms.Timer();

            m_Timer.Interval = 2000;
            m_Timer.Tick += timer_Tick;
            m_Timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            RefreshProcesses();
        }

        private void RefreshProcesses()
        {
            List<string> listbox = new List<string>();
            
            Process[] processes = Process.GetProcesses();

            foreach (var proc in processes)
            {
                if (!string.IsNullOrEmpty(proc.ProcessName))
                    listbox.Add(proc.ProcessName);
            }
            listBox1.DataSource = listbox;

            if (listBox1.Items.Contains("server"))
            {
                serverLabel.Text = "Server Status: Running";
            }
            if (!listBox1.Items.Contains("server"))
            {
                Process.Start(Directory.GetCurrentDirectory() + "\\server.exe");
                serverLabel.Text = "Server Status: Not Running";
                // start process
            }
            if (listBox1.Items.Contains("wServer"))
            {
                wserverLabel.Text = "wServer Status: Running";
            }
            if (!listBox1.Items.Contains("wServer"))
            {
                Process.Start(Directory.GetCurrentDirectory() + "\\wServer.exe");
                wserverLabel.Text = "wServer Status: Not Running";
                // start process
            }
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            Process.Start("www.github.com/R1S3MPGH");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple C# application that views a list box with running applications on your pc and detects if wServer or server is running.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You probably don't want this open when compiling your source, as you will get errors if server/wServer is open during the build.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is just a ListBox of running processes on your pc, which is how the application detects if wServer and/or server is running so the Status Labels will say if it is running or not.");
        }
    }
}
