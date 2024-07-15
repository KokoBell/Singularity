using Singularity.Interfaces;
using System;
using System.Diagnostics;

namespace Singularity.Components
{
    public class ProcessExecutor : IProcessExecutor
    {
        public Process ProcessToExecute;

        public ProcessExecutor()
        {
            ProcessToExecute = new Process();
        }

        private void SetupScriptOptions(string filePath) 
        {
            ProcessToExecute.StartInfo.FileName = "cmd.exe";
            ProcessToExecute.StartInfo.Arguments = $"/c \"{filePath}\"";
            ProcessToExecute.StartInfo.UseShellExecute = false;
            ProcessToExecute.StartInfo.CreateNoWindow = false;
        }

        private void SetupScriptAdmin(string filePath)
        {
            SetupScriptOptions(filePath);

            ProcessToExecute.StartInfo.UseShellExecute = true; // UseShellExecute set to true to run with elevated privileges
            ProcessToExecute.StartInfo.Verb = "runas"; // Run the process as administrator
        }

        private void SetupScriptArguments(string filePath, string[] args)
        {
            
        }

        private void StartProcess()
        {
            ProcessToExecute.Start();
            ProcessToExecute.WaitForExit();
        }

        public void ExecuteBatScript(string filePath)
        {
            SetupScriptOptions(filePath);
            StartProcess();
        }

        public void ExecuteBatScriptAsAdmin(string filePath)
        {
            SetupScriptAdmin(filePath);
            StartProcess();
        }
    }
}
