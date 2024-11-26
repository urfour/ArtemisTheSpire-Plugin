using Artemis.Core.Modules;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Management;

namespace Artemis.Plugins.Games.SlayTheSpire.Prerequisites
{
    public class StsProcessActivationRequirement : IModuleActivationRequirement
    {
        public StsProcessActivationRequirement() { }

        public bool Evaluate()
        {
            var processes1 = Process.GetProcessesByName("javaw");
            var processes2 = Process.GetProcessesByName("java");
            var processes = processes1.Concat(processes2);

            return processes.Any(proc => GetCommandLine(proc).ToLower().Contains("spire"));
        }

        public string GetUserFriendlyDescription()
        {
            string text = "Requirement met when Slay the Spire is running";
            return text;
        }

        static string GetCommandLine(Process process)
        {
            string commandLine = "";
            if (OperatingSystem.IsWindows())
            {
                using (var searcher = new ManagementObjectSearcher(
                    "SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id))
                {
                    foreach (var @object in searcher.Get())
                    {
                        commandLine += @object["CommandLine"] + " ";
                    }
                }
            }
            return commandLine.Trim();
        }
    }
}
