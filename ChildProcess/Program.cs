using VisualStudioDebuggerLauncher;
using System;

namespace ChildProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            DebuggerLauncher.AttachDebugger("VisualStudioDebuggerLauncher.sln");
            Console.WriteLine("Hello World");
        }
    }
}
