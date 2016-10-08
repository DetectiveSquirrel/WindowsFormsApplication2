using System;
using System.Threading;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.ActiveControl = null;  //this = form
            label1.Text = "Status: Started";
            System.Diagnostics.Process proc = new System.Diagnostics.Process(); // Declare New Process
            proc.StartInfo.FileName = @"Batch Files\Start.bat";
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;  //this = form
            label1.Text = "Status: Stopped";
            System.Diagnostics.Process proc = new System.Diagnostics.Process(); // Declare New Process
            proc.StartInfo.FileName = @"Batch Files\Stop.bat";
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {

            this.ActiveControl = null;  //this = form
            label1.Text = "Status: Restarted";
            System.Diagnostics.Process proc = new System.Diagnostics.Process(); // Declare New Process
            proc.StartInfo.FileName = @"Batch Files\Restart.bat";
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.ActiveControl = null;  //this = form
            label1.Text = "Status: Started With Looper";
            System.Diagnostics.Process proc = new System.Diagnostics.Process(); // Declare New Process
            proc.StartInfo.FileName = @"Batch Files\Start With Restarts.bat";
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;  //this = form
            label1.Text = "Status: Using Normal Config";
            System.Diagnostics.Process proc = new System.Diagnostics.Process(); // Declare New Process
            proc.StartInfo.FileName = @"Batch Files\Normal Config.bat";
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
        }

        private void BottingConfigButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;  //this = form
            label1.Text = "Status: Using Botting Config";
            System.Diagnostics.Process proc = new System.Diagnostics.Process(); // Declare New Process
            proc.StartInfo.FileName = @"Batch Files\Botting Config.bat";
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();

        }
    }
}
