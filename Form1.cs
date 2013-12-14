using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using IWshRuntimeLibrary;

namespace DayZ_Epoch_Updater
{

    public partial class Form1 : Form
    {

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;  //this indicates that the action takes place on the title bar

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Form1()
        {
            
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(move_window);
            if (System.IO.File.Exists("last_port_save"))
            {
                string port1 = System.IO.File.ReadAllText(@"last_port_save");
                try
                {
                    this.textBox4.Text = port1;
                    
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                
                string port = "Port";
                System.IO.File.Create("last_port_save").Dispose();
                System.IO.File.WriteAllText("last_port_save", port);
                
                
            }
            //port2
            if (System.IO.File.Exists("last_port2_save"))
            {
                string port2 = System.IO.File.ReadAllText(@"last_port2_save");
                try
                {
                    this.textBox6.Text = port2;
                    
                }
                catch (Exception ex)
                {

                }
            }
            else
            {

                string port2 = "Port";
                System.IO.File.Create("last_port2_save").Dispose();
                System.IO.File.WriteAllText("last_port2_save", port2);
                

            }
            //Port 3
            if (System.IO.File.Exists("last_port3_save"))
            {
                string port3 = System.IO.File.ReadAllText(@"last_port3_save");
                try
                {
                    this.textBox7.Text = port3;
                    
                }
                catch (Exception ex)
                {

                }
            }
            else
            {

                string port3 = "Port";
                System.IO.File.Create("last_port3_save").Dispose();
                System.IO.File.WriteAllText("last_port3_save", port3);
                

            }

            if (System.IO.File.Exists("last_ip_save"))
            {
                string ip1 = System.IO.File.ReadAllText(@"last_ip_save");
                try
                {
                    this.textBox3.Text = ip1;
                    
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                string ip = "IP";
                System.IO.File.Create("last_ip_save").Dispose();
                System.IO.File.WriteAllText("last_ip_save", ip);
                
                
            }
            //IP 2
            if (System.IO.File.Exists("last_ip2_save"))
            {
                string ip2 = System.IO.File.ReadAllText(@"last_ip2_save");
                try
                {
                    this.textBox1.Text = ip2;
                    
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                string ip2 = "IP";
                System.IO.File.Create("last_ip2_save").Dispose();
                System.IO.File.WriteAllText("last_ip2_save", ip2);
                

            }
            //IP 3
            if (System.IO.File.Exists("last_ip3_save"))
            {
                string ip3 = System.IO.File.ReadAllText(@"last_ip3_save");
                try
                {
                    this.textBox5.Text = ip3;
                    
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                string ip3 = "IP";
                System.IO.File.Create("last_ip3_save").Dispose();
                System.IO.File.WriteAllText("last_ip3_save", ip3);
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.textBox2.Enabled = true;
            }
            else { this.textBox2.Enabled = false; }

            if (radioButton7.Checked)
            {
                checkBox1.Enabled = true;
            }
            else { checkBox1.Enabled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "http://dayzepoch.com";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process donate = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                donate.StartInfo.UseShellExecute = true;
                donate.StartInfo.FileName = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=MLTEDU37NJ9ZY";
                donate.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new about().Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Alpha Version 1.0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon...");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon...");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string ip = textBox3.Text;
            string port = textBox4.Text;

            // Epoch Vanilla

            if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
            {
                System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo sdpsinfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                sdpsinfo.RedirectStandardOutput = true;
                sdpsinfo.UseShellExecute = false;
                sdpsinfo.CreateNoWindow = true;
                p1.StartInfo = sdpsinfo;
                p1.Start();
            }
            else
            {
                MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string ip = textBox3.Text;
            string port = textBox4.Text;

            // Epoch Panthera

            if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
            {
                System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo sdpsinfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZPanthera;@DayZ_Epoch -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                sdpsinfo.RedirectStandardOutput = true;
                sdpsinfo.UseShellExecute = false;
                sdpsinfo.CreateNoWindow = true;
                p1.StartInfo = sdpsinfo;
                p1.Start();
            }
            else
            {
                MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string ip = textBox3.Text;
            string port = textBox4.Text;

            // Epoch Taviana

            if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
            {
                System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo sdpsinfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@Taviana;@DayZ_Epoch -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                sdpsinfo.RedirectStandardOutput = true;
                sdpsinfo.UseShellExecute = false;
                sdpsinfo.CreateNoWindow = true;
                p1.StartInfo = sdpsinfo;
                p1.Start();
            }
            else
            {
                MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string ip = textBox3.Text;
            string port = textBox4.Text;
            string mod = textBox2.Text;

            string ip2 = textBox1.Text;
            string port2 = textBox6.Text;

            string ip3 = textBox5.Text;
            string port3 = textBox7.Text;

            if (radioButton4.Checked && !radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked || radioButton5.Checked && !radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked || radioButton6.Checked && !radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Please choose your Server ip!");
            }
            if (!checkBox1.Checked && radioButton7.Checked)
            {
                MessageBox.Show("Please activate your custom launch parameters or select your Mod!");
            }

            // Epoch Custom 1

            if (checkBox1.Checked && radioButton1.Checked && checkBox1.Enabled)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe " + mod + " -connect=" + ip + " -port=" + port + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Custom 2

            if (checkBox1.Checked && radioButton2.Checked && checkBox1.Enabled)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe " + mod + " -connect=" + ip2 + " -port=" + port2 + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Custom 3

            if (checkBox1.Checked && radioButton3.Checked && checkBox1.Enabled)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe " + mod + " -connect=" + ip3 + " -port=" + port3 + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }

            // Epoch Vanilla IP1

            if (radioButton4.Checked && radioButton1.Checked)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch -connect=" + ip + " -port=" + port + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Vanilla IP2

            if (radioButton4.Checked && radioButton2.Checked)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch -connect=" + ip2 + " -port=" + port2 + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Vanilla IP3

            if (radioButton4.Checked && radioButton3.Checked)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch -connect=" + ip3 + " -port=" + port3 + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Panthera IP1

            if (radioButton6.Checked && radioButton1.Checked)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch;@DayZPanthera -connect=" + ip + " -port=" + port + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Panthera IP2

            if (radioButton6.Checked && radioButton2.Checked)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch;@DayZPanthera -connect=" + ip2 + " -port=" + port2 + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Panthera IP3

            if (radioButton6.Checked && radioButton3.Checked)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch;@DayZPanthera -connect=" + ip3 + " -port=" + port3 + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Taviana IP1

            if (radioButton5.Checked && radioButton1.Checked)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch;@Taviana -connect=" + ip + " -port=" + port + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Taviana IP2

            if (radioButton5.Checked && radioButton2.Checked)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch;@Taviana -connect=" + ip2 + " -port=" + port2 + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
            // Epoch Taviana IP3

            if (radioButton5.Checked && radioButton3.Checked)
            {
                if (System.IO.File.Exists("Expansion/beta/arma2oa.exe"))
                {
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo sdpsinfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", @"/c start Expansion/beta/arma2oa.exe -mod=@DayZ_Epoch;@Taviana -connect=" + ip3 + " -port=" + port3 + " -nosplash -skipIntro -noPause -nosplash -skipIntro -world=empty");
                    sdpsinfo.RedirectStandardOutput = true;
                    sdpsinfo.UseShellExecute = false;
                    sdpsinfo.CreateNoWindow = true;
                    p1.StartInfo = sdpsinfo;
                    p1.Start();
                }
                else
                {
                    MessageBox.Show("Please copy the launcher into your Arma2 OA folder!");
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //IP1
            if (textBox3.Text == "IP")
            { }
            else
            {
                System.IO.File.WriteAllText("last_ip_save", textBox3.Text);
            }
            //IP2
            if (textBox1.Text == "IP")
            { }
            else
            {
                System.IO.File.WriteAllText("last_ip2_save", textBox1.Text);
            }
            //IP3
            if (textBox5.Text == "IP")
            { }
            else
            {
                System.IO.File.WriteAllText("last_ip3_save", textBox5.Text);
            }

            //Port1
            if (textBox4.Text == "Port")
            { }
            else
            {
                System.IO.File.WriteAllText("last_port_save", textBox4.Text);
            }

            //Port2
            if (textBox6.Text == "Port")
            { }
            else
            {
                System.IO.File.WriteAllText("last_port2_save", textBox6.Text);
            }
            //Port3
            if (textBox7.Text == "Port")
            { }
            else
            {
                System.IO.File.WriteAllText("last_port3_save", textBox7.Text);
            }
        }
        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            var thisPath = System.IO.Directory.GetCurrentDirectory();
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "DayZ Epoch Launcher";   // The description of the shortcut
            //shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.WorkingDirectory = thisPath;
            shortcut.Save();                                    // Save the shortcut
        }
        private void desktopShortcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateShortcut("DayZ Epoch Launcher", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Assembly.GetExecutingAssembly().Location);

            MessageBox.Show("desktop shortcut has been added");
        }

        private void installBetaPatch103718ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("ARMA2_OA_Build_103718.exe"))
            {
                DialogResult dialogResult = MessageBox.Show("Install arma beta patch?", "Beta patch install for Epoch", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Process.Start("ARMA2_OA_Build_103718.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Install aborted");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Install arma beta patch?", "Beta patch install for Epoch", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        System.IO.File.WriteAllBytes("ARMA2_OA_Build_103718.exe", Properties.Resources.ARMA2_OA_Build_103718);
                        Process.Start("ARMA2_OA_Build_103718.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Install aborted");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //
                }

            }
        }
    }
}
