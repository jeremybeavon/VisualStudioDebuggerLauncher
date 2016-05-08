# Overview

Provides a method that attches a debugger to a currently running Visual Studio instance. Code adapted from: https://gist.github.com/atruskie/3813175

# Usage

```csharp
using VisualStudioDebuggerLauncher;
using System;

class Program
{
  static void Main(string[] args)
  {
    DebuggerLauncher.AttachDebugger("VisualStudioDebuggerLauncher.sln");
    Console.WriteLine("Hello World");
  }
}
```
