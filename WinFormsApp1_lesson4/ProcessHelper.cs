using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1_lesson4;

internal static class ProcessHelper
{
    private const string unknownProcessName = "Unknown process";
    public static List<ProcessWraper> GetProcesses()
    {
        var wrapers=new List<ProcessWraper>();

        Process[] allProcesses = Process.GetProcesses();

        for (int i = 0; i < allProcesses.Length; i++)
        {
            wrapers.Add(new ProcessWraper(allProcesses[i]));
        }
        Logger loger = new Logger();
        loger.LogData(LogLevel.Info, $"Some message. Count={ allProcesses.Length}");

        return wrapers;
    }
    public static bool Start(string nameOrPath)
    {
        // Start
        try
        {
            if (!string.IsNullOrEmpty(nameOrPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = nameOrPath,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
                // Info
                return true;
            }
        }
        catch (Win32Exception)
        {
            Debug.WriteLine($"Acess denied to {nameOrPath} process.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Process {nameOrPath} cannot be started. Message={ex.Message}");
        }

        return false;
    }

    // notepad
    // Notepad
    // Notepa
    // otepad
    public static bool Stop(string name, bool all = false)
    {
        if (!string.IsNullOrEmpty(name))
        {
            name = name.ToLower();
            Process[] processes;

            // 1.
            processes = Process.GetProcesses();

            // Possible way to handle "all param"
            /*
            List<Process> allProcesses = processes.ToList();
            List<Process> processesToStop = allProcesses
                .Where(p => !string.IsNullOrEmpty(p?.ProcessName ?? string.Empty) && p.ProcessName.ToLower().Contains(name))
                .ToList();
            processesToStop = all ? processesToStop : processesToStop.Take(1).ToList();
            */

            for (int i = 0; i < processes.Length; i++)
            {
                string processName = processes[i].ProcessName ?? string.Empty;
                if (!string.IsNullOrEmpty(processName) && processName.ToLower().Contains(name))
                {
                    //processes[i].CloseMainWindow();
                    Stop(processes[i]);

                    if (!all)
                    {
                        return true;
                    }
                }
            }

            // 2.
            // processes = Process.GetProcessesByName(name);
        }

        return false;
    }

    public static bool Stop(Process process)
    {
        string name = unknownProcessName;

        try
        {
            if (process != null)
            {
                name = process.ProcessName; // ??? what if have no access
                process.Kill();

                return true;
            }
        }
        catch (Win32Exception)
        {
            Debug.WriteLine($"Acess denied to {name} process.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Process {name} cannot be stopped. Message={ex.Message}");
        }

        return false;
    }
   
    
    
    
}
