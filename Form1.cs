using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerCrashingTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crash_Click(object sender, EventArgs e)
        {
            fork();
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startinfo = new ProcessStartInfo("shutdown.exe", "-s");
            Process.Start(startinfo);
        }
        public static void fork()
        {
            while (true)
            {
                fork();
            }
        }
    }
}
