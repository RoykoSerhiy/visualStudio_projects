using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using CourceWork.Clases;


namespace CourceWork
{
    public partial class Form1 : Form
    {
        //bool bDeviceFound = false;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        const int WM_DEVICECHANGE = 0x0219;
        const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const uint DBT_DEVTYP_VOLUME = 0x00000002;
        public string Directory;
        public string SerialNum;
        public string FSize;
        public bool copySubDirectories = false;
        Thread th;
        public enum Priority { Lowest, Normal, BeloweNormal, AboveNormal, Higest };
        Priority p;
        public FlashDrive fd;


        [StructLayout(LayoutKind.Sequential)]
        public struct DEV_BROADCAST_HDR
        {
            public int dbch_size;
            public int dbch_devicetype;
            public int dbch_reserved;
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct DEV_BROADCAST_VOLUME
        {
            public uint dbcv_size;
            public uint dbcv_devicetype;
            public uint dbcv_reserved;
            public uint dbcv_unitmask;
            public ushort dbcv_flags;
        }
        public Form1()
        {
            InitializeComponent();
            rbNormal.Checked = true;
            tbxDestPath.Text = @"E:\gif";
            
            //MessageBox.Show(p.ToString());
        }
        
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            try
            {
                int EventCode = m.WParam.ToInt32();
               
                if (m.Msg == WM_DEVICECHANGE)
                {
                    switch (EventCode)
                    {
                        case DBT_DEVICEARRIVAL:
                            {
                                DEV_BROADCAST_HDR dbhARRIVAL = (DEV_BROADCAST_HDR)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_HDR));
                                if (dbhARRIVAL.dbch_devicetype == DBT_DEVTYP_VOLUME)
                                {
                                    DEV_BROADCAST_VOLUME dbv = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));
                                    BitArray bArray = new BitArray(new byte[]
                                   {
                                       (byte)(dbv.dbcv_unitmask & 0x00FF),
                                       (byte)((dbv.dbcv_unitmask & 0xFF00) >> 8),
                                       (byte)((dbv.dbcv_unitmask & 0xFF0000) >> 16),
                                       (byte)((dbv.dbcv_unitmask & 0xFF000000) >> 24)
                                       
                                   });
                                    int DriveLetter = Char.ConvertToUtf32("A", 0);
                                    for (int i = 0; i < bArray.Length; ++i)
                                    {
                                        if (bArray.Get(i))
                                        {
                                            Connect(Char.ConvertFromUtf32(DriveLetter));
                                        }
                                        DriveLetter += 1;
                                    }
                                }
                                
                                Log(Directory, true);
                                Thread.Sleep(2500);
                                GetSerialNumber();
                                fd = new FlashDrive();
                                fd.SerialNum = SerialNum;
                                fd.path = Directory;
                                fd.Size = FSize;
                                fd.CheckList();
                                lbFlashes.Items.Add(fd.SerialNum);
                               // lbFlashes.SelectedIndex = 0;
                                lblInfo.Text = "Path: " + fd.path + "\nSerial Num: " +
                                    fd.SerialNum  + "\nSize: " + fd.Size + "\nIs White: " + fd.isWhite;
                                if (fd.isWhite == true)
                                {
                                    MessageBox.Show("White Flash");
                                }
                                else
                                {
                                    if (tbxDestPath.Text == null || tbxDestPath.Text == " ")
                                    {
                                        MessageBox.Show("Wrong Path");
                                        tbxDestPath.Text = @"E:\gif";
                                    }
                                    if (tbxFormat.Text == null || tbxFormat.Text == " ")
                                    {
                                        th = new Thread(delegate() { fd.CopyFiles(fd.path, tbxDestPath.Text, copySubDirectories); });
                                    }
                                    else
                                    {
                                        th = new Thread(delegate() { fd.CopyFilesbyExtention(fd.path, tbxDestPath.Text, tbxFormat.Text,copySubDirectories); });
                                    }
                                    switch (p)
                                    {
                                        case Priority.Lowest:
                                            {
                                                th.Priority = ThreadPriority.Lowest;
                                            }
                                            break;
                                        case Priority.BeloweNormal:
                                            {
                                                th.Priority = ThreadPriority.BelowNormal;
                                            }
                                            break;
                                        case Priority.Normal:
                                            {
                                                th.Priority = ThreadPriority.Normal;
                                            }
                                            break;
                                        case Priority.AboveNormal:
                                            {
                                                th.Priority = ThreadPriority.AboveNormal;
                                            }
                                            break;
                                        case Priority.Higest:
                                            {
                                                th.Priority = ThreadPriority.Highest;
                                            }
                                            break;
                                    }
                                    th.Start();
                                }
                                break;
                            }
                    }

                    if (m.Msg == WM_DEVICECHANGE)
                    {
                        switch (EventCode)
                        {
                            case DBT_DEVICEREMOVECOMPLETE:
                                {
                                    Log(string.Format("Удаление устройства. DBT_DEVICEREMOVECOMPLETE", EventCode));
                                    Log(Directory, false);
                                    foreach (var l in lbFlashes.Items)
                                    {
                                        if(l.ToString() == SerialNum)
                                        {
                                            lblInfo.Text = null;
                                            lbFlashes.Items.Remove(l);
                                            break;
                                        }
                                    }
                                    
                                    break;
                                }
                        }
                    }

                  
                }
                base.WndProc(ref m);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        


        private void Log(string s)
        {
            //MessageBox.Show(s);
        }
        private void Connect(string Dir)
        {
            
            string root = string.Format(@"{0}:\", Dir);
            MessageBox.Show(string.Format("{0} подключён.", root));
            Directory = root;
        }
        private void Log(string dir, bool isArrival)
        {

            DriveInfo di = new DriveInfo(Directory);
            StringBuilder sb = new StringBuilder();
            StreamWriter sw = new StreamWriter("Log.txt", true);
            if (isArrival == true)
            {
                string FreeSpace = (di.TotalFreeSpace / Math.Pow(2, 30)).ToString("#.##");
                string TotalSpace = (di.TotalSize / Math.Pow(2, 30)).ToString("#.##");
                FSize = TotalSpace;
                sb.AppendLine((DateTime.Now).ToString());
                sb.AppendLine(String.Format(":Підключено пристрій {0}", Directory));
                sb.AppendLine(String.Format("\nТип пристрою {0}", di.DriveType));
                sb.AppendLine(String.Format("\nВільний простір {0} Гб", FreeSpace));
                sb.AppendLine(String.Format("\nЗагальний простір {0} Гб", TotalSpace));
                sw.WriteLine(sb.ToString());
                sw.Close();
            }
            else
            {
                sb.AppendLine((DateTime.Now).ToString());
                sb.AppendLine(String.Format(":Відключено пристрій {0}", Directory));
                sw.WriteLine(sb.ToString());
                sw.Close();
            }

        }
        private void GetSerialNumber()
        {
            ManagementObjectSearcher theSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB'");
            foreach (ManagementObject currentObject in theSearcher.Get())
            {
                ManagementObject theSerialNumberObjectQuery = new ManagementObject("Win32_PhysicalMedia.Tag='" + currentObject["DeviceID"] + "'");
                SerialNum = theSerialNumberObjectQuery["SerialNumber"].ToString();
                MessageBox.Show(SerialNum);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 773;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Width = 346;
        }

        private void btnAddToWhiteList_Click(object sender, EventArgs e)
        {
            fd.AddToWhiteList(lbFlashes.SelectedItem.ToString());
            //MessageBox.Show(lbFlashes.SelectedItem.ToString());
        }
        private void btnDeleteFromWhiteList_Click(object sender, EventArgs e)
        {
            fd.DeleteFromWhiteList(lbFlashes.SelectedItem.ToString());
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
             Show();
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                copySubDirectories = true;
            }
           else
                if (checkBox1.Checked == false)
                {
                    copySubDirectories = false;
                }
            
        }

        private void rbLowest_CheckedChanged(object sender, EventArgs e)
        {
            p = Priority.Lowest;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbBeloweNormal_CheckedChanged(object sender, EventArgs e)
        {
            p = Priority.BeloweNormal;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            p = Priority.Normal;
        }

        private void rbAboveNormal_CheckedChanged(object sender, EventArgs e)
        {
            p = Priority.AboveNormal;
        }

        private void rbHigest_CheckedChanged(object sender, EventArgs e)
        {
            p = Priority.Higest;
        }
        
    }
}
