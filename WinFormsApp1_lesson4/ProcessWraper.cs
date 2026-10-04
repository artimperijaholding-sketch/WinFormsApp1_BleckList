using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace WinFormsApp1_lesson4;

internal class ProcessWraper
{
    private Process process;

    public ProcessWraper(Process process)
    {
        this.process = process;
    }

    public Process GetInnerProcess()
    {
        return process;
    }
    public string GetProcessInfo()
    {
        try
        {
            return $"Process Name: {process.ProcessName}\r\n" +
                $"ID: {process.Id}\r\n" +
                $"Start Time: {process.StartTime}\r\n" +
                $"Memory Usage: {process.WorkingSet64 / 1024 / 1024} MB\r\n" +
                $"Priority: {process.BasePriority}\r\n" +
                $"Threads: {process.Threads.Count}\r\n";
        }
        catch (Win32Exception)
        {
            return "Acess denied to some process information.";
        }
        catch (Exception)
        {
            return "Precess has bin terminated.";
        }
    }
    
    public override string ToString()=> process?.ProcessName ?? "Unknown process";
    
}
