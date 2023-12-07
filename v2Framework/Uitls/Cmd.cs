using System;
using System.Diagnostics;
using System.Management;

namespace v2Framework.Uitls
{
    public class Cmd
    {
        private Process process_0;

        public int ExecuteCMD(string command, bool isHidden)
        {
            this.process_0 = new Process();
            this.process_0.StartInfo.FileName = "CMD.exe";
            this.process_0.StartInfo.Arguments = "/C " + command;
            if (isHidden)
                this.process_0.StartInfo.CreateNoWindow = true;
            this.process_0.Start();

            return this.process_0.Id;
        }

        public int ExecuteProcess(string path, string command, bool isHidden)
        {
            this.process_0 = new Process();
            this.process_0.StartInfo.FileName = path;
            this.process_0.StartInfo.Arguments = command;
            if (isHidden)
                this.process_0.StartInfo.CreateNoWindow = true;
            this.process_0.Start();

            return this.process_0.Id;
        }

        public void stopCMD()
        {
            this.process_0.Kill();
            this.process_0.Close();
        }

        public static void KillProcessAndChildren(int pid)
        {
            if (pid != 0)
            {
                using (var searcher = new ManagementObjectSearcher
                    ("Select * From Win32_Process Where ParentProcessID=" + pid))
                {
                    var moc = searcher.Get();
                    foreach (ManagementObject mo in moc)
                    {
                        KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                    }
                    try
                    {
                        var proc = Process.GetProcessById(pid);
                        proc.Kill();
                    }
                    catch (Exception e)
                    {
                        e.Message.ToLower();
                    }
                }
            }
        }
    }

}
