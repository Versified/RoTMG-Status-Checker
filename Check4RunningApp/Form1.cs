using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check4RunningApp
{
    public partial class Form1 : Form
    {
        // This/These are the variables the form will use.
        private readonly ServerManager manager;

        // This is the constructor for the form.
        public Form1()
        {
            InitializeComponent();
            manager = new ServerManager(this);
        }

        // This will change some values when the form loads.
        private void Form1_Load(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;

            pauseCheckBox.Enabled = false;
        }

        #region Button Click Handlers

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;

            pauseCheckBox.Enabled = true;

            manager.StartServer();
            manager.StartwServer();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;

            pauseCheckBox.Enabled = false;

            OnwServerClose();
            OnServerClose();
            StopEverything();
        }

        #endregion Button Click Handlers

        #region Server Open and Close

        public void OnServerOpen()
        {
            serverLabel.Text = "Server.exe: Online";
            serverLabel.ForeColor = Color.Green;
        }

        public void OnServerClose()
        {
            serverLabel.Text = "Server.exe: Offline";
            serverLabel.ForeColor = Color.Red;
        }

        public void OnwServerOpen()
        {
            wserverLabel.Text = "wServer.exe: Online";
            wserverLabel.ForeColor = Color.Green;
        }

        public void OnwServerClose()
        {
            wserverLabel.Text = "wServer.exe: Offline";
            wserverLabel.ForeColor = Color.Red;
        }

        #endregion Server Open and Close

        // This will close both of the servers
        private void StopEverything()
        {
            manager.StopServer();
            manager.StopwServer();
        }

        // This is a boolean to check if the paused button is checked
        public bool isPaused()
        {
            if (pauseCheckBox.Checked)
                return true;
            return false;
        }

        // This will append text to the debug box
        public void AppendText(string text)
        {
            this.debugBox.AppendText(text + "\n");
        }
    }
}