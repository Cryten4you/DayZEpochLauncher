using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DayZ_Epoch_Updater
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process domain = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                domain.StartInfo.UseShellExecute = true;
                domain.StartInfo.FileName = "http://www.crymedia.de";
                domain.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
