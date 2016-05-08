using System.Collections.Generic;
using System.Diagnostics;

namespace VisualStudioDebuggerLauncher
{
    public static class DebuggerLauncher
    {
        [Conditional("DEBUG")]
        public static void AttachDebugger(params string[] solutions)
        {
        	if (!Debugger.IsAttached)
        	{
        		// do a search for any Visual Studio processes that also have our solution currently open
        		var vsProcess =
        			VisualStudioAttacher.GetVisualStudioForSolutions(new List<string>(solutions));
        				
        		if (vsProcess != null) 
        		{
        			VisualStudioAttacher.AttachVisualStudioToProcess(vsProcess, Process.GetCurrentProcess());
        		}
        		else
        		{
        			// try and attach the old fashioned way
        			Debugger.Launch();
        		}
        	}
        }
    }
}
