using System;
using System.Diagnostics;
using System.IO;

namespace ParentProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Process process = Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ChildProcess.exe")))
            {
                process.WaitForExit();
            }
        }
    }
}
