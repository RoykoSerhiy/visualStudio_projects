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
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Management;

namespace ProcessManipulation
{
    public partial class Form1 : Form
    {
        const uint WM_SETTEXT = 0x0c;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd , uint Msg , int wParam
            ,[MarshalAs(UnmanagedType.LPStr)] string lParam);
        List<Process> Processes = new List<Process>();
        int Counter = 0;
        public Form1()
        {
            InitializeComponent();
            LoadAvailebleAssemblies();
        }
        public void LoadAvailebleAssemblies()
        {
            try
            {
                string except = new FileInfo(Application.ExecutablePath).Name;

                except = except.Substring(0, except.IndexOf("."));
                string[] files = Directory.GetFiles(Application.StartupPath, "*.exe");
                foreach (var file in files)
                {
                    string fileName = new FileInfo(file).Name;
                    if (fileName.IndexOf(except) == -1)
                    {
                        AvailebleAssemblies.Items.Add(fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                 
        }
        public void RunProcess(string AssamblyName)
        {
            try
            {
                Process proc = Process.Start(AssamblyName);
                Processes.Add(proc);
                if (Process.GetCurrentProcess().Id == GetParrentProcessId(proc.Id))
                {
                    MessageBox.Show(proc.ProcessName + " child process current process");

                }
                proc.EnableRaisingEvents = true;
                proc.Exited += proc_Exited;

                SetChildWindowText(proc.MainWindowHandle, "Child Process# " + (++Counter));

                if (!StartedProcess.Items.Contains(proc.ProcessName))
                {
                    StartedProcess.Items.Add(proc.ProcessName);
                }
                AvailebleAssemblies.Items.Remove(AvailebleAssemblies.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SetChildWindowText(IntPtr Handler, string text)
        {
            try
            {
                SendMessage(Handle, WM_SETTEXT, 0, text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int GetParrentProcessId(int id)
        {
            
                int parrentId = 0;
                try
                {
                using (ManagementObject obj =
                    new ManagementObject("win32_process.handle=" + id.ToString()))
                {
                    obj.Get();
                    parrentId = Convert.ToInt32(obj["ParrentProcessId"]);
                }
               
            }
            catch (ManagementException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
                return parrentId;
        }
        public void proc_Exited(object sender , EventArgs e)
        {
            try
            {
                Process proc = sender as Process;
                StartedProcess.Items.Remove(proc.ProcessName);
                AvailebleAssemblies.Items.Add(proc.ProcessName);
                Processes.Remove(proc);
                Counter--;
                int index = 0;
                foreach (var p in Processes)
                    SetChildWindowText(p.MainWindowHandle, "Child process#" + ++index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        delegate void ProcessDelegate(Process proc);
        void ExecuteOnProcessesByName(string ProcessName , ProcessDelegate func)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(ProcessName);
                foreach (var p in processes)
                    if (Process.GetCurrentProcess().Id == GetParrentProcessId(p.Id))
                        func(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                RunProcess(AvailebleAssemblies.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Kill(Process proc)
        {
            proc.Kill();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteOnProcessesByName(StartedProcess.SelectedItem.ToString(), Kill);
                StartedProcess.Items.Remove(StartedProcess.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void CloseMainWindow(Process proc)
        {
            proc.CloseMainWindow();
             
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            ExecuteOnProcessesByName(StartedProcess.SelectedItem.ToString() , CloseMainWindow);
            StartedProcess.Items.Remove(StartedProcess.SelectedItem);
        }
        void Refresh(Process proc)
        {
            proc.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteOnProcessesByName(StartedProcess.SelectedItem.ToString(), Refresh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AvailebleAssemblies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AvailebleAssemblies.SelectedItems.Count == 0)
            {
                btnStart.Enabled = false;
            }
            else
            {
                btnStart.Enabled = true;
            }
        }

        private void StartedProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(StartedProcess.SelectedItems.Count == 0)
            {
                btnStop.Enabled = false;
                btnCloseWindow.Enabled = false;
            }
            else
            {

                btnStop.Enabled = true;
                btnCloseWindow.Enabled = true;
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var proc in Processes)
            {
                proc.Kill();
            }
        }

        private void btnRunCalc_Click(object sender, EventArgs e)
        {
            RunProcess("calc.exe");
        }

    }
}
