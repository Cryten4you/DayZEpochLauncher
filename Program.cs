using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace DayZ_Epoch_Updater
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "DayZ_Epoch_Updater.exe");
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Only one instance at a time, launcher is allready open");
            }
        }
    }
}
