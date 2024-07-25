﻿using Singularity.Interfaces;
using System;
using System.Diagnostics;

namespace Singularity.Components
{
    public class BatExecutor : IProcessExecutor
    {
        public Process ProcessToExecute;

        public BatExecutor()
        {
            ProcessToExecute = new Process();
        }

        #region Private Methods

        private void SetupScriptOptions(string filePath) 
        {
            ProcessToExecute.StartInfo.FileName = "cmd.exe";
            ProcessToExecute.StartInfo.Arguments = $"/c \"{filePath}\"";
            ProcessToExecute.StartInfo.UseShellExecute = false;
            ProcessToExecute.StartInfo.CreateNoWindow = false;
        }

        private void SetupScriptAdmin(string filePath)
        {
            ProcessToExecute.StartInfo.UseShellExecute = true; // UseShellExecute set to true to run with elevated privileges
            ProcessToExecute.StartInfo.Verb = "runas"; // Run the process as administrator
        }

        private void SetupScriptArguments(string filePath, string[] args)
        {
            SetupScriptOptions(filePath);
            string fullArgs = $"/c {string.Join(' ', args).Replace(filePath, $"\"{filePath}\"")}";
            ProcessToExecute.StartInfo.Arguments = fullArgs;
        }

        private void SetupScriptArgumentsAdmin(string filePath, string[] args)
        {
            SetupScriptArguments(filePath, args);
            SetupScriptAdmin(filePath);
        }

        private void StartProcess()
        {
            ProcessToExecute.Start();
            ProcessToExecute.WaitForExit();
        }

        #endregion

        public void ExecuteProcess(string filePath)
        {
            SetupScriptOptions(filePath);
            StartProcess();
        }

        public void ExecuteProcess(string filePath, string[] args)
        {
            SetupScriptArguments(filePath, args);
            StartProcess();
        }

        public void ExecuteProcessAsAdmin(string filePath)
        {
            SetupScriptOptions(filePath);
            SetupScriptAdmin(filePath);
            StartProcess();
        }

        public void ExecuteProcessAsAdmin(string filePath, string[] args)
        {
            SetupScriptArgumentsAdmin(filePath, args);
            StartProcess();
        }
    }
}