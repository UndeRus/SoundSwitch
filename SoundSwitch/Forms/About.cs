﻿using System.Diagnostics;
using System.Windows.Forms;

namespace SoundSwitch.Forms
{
    public partial class About : Form
    {
        private static readonly About instance = new About();
        public static About Instance
        {
            get { return instance; }
        }

        static About()
        {
            Instance.Closing += (sender, e) =>
            {
                e.Cancel = true;
                Instance.Hide();
            };
        }

        private About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://jeroenpelgrims.be");
        }

        private void About_Load(object sender, System.EventArgs e)
        {
            var version = Application.ProductVersion;
            txtVersion.Text = version;
        }

        private void Version_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://soundswitch.codeplex.com/releases");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.fatcow.com/free-icons/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.liensberger.it/web/blog/?p=207");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://spikex.net/2011/05/programmatically-changing-the-default-audio-playback-device-on-windows-vista-windows-7/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.daveamenta.com/2011-05/programmatically-or-command-line-change-the-default-sound-playback-device-in-windows-7/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://johnnycoder.com/blog/2009/02/24/clickonce-run-at-startup/");
        }
    }
}