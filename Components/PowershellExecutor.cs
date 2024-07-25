using System.Diagnostics;

namespace Singularity.Interfaces
{
    public class PowershellExecutor : IProcessExecutor
    {
        public void ExecuteProcess(string filePath)
        {
            Debugger.Break();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-File \"{filePath}\"",
                UseShellExecute = false,
                CreateNoWindow = false
            };
            Process.Start(startInfo);
        }

        public void ExecuteProcess(string filePath, string[] args)
        {
            string arguments = string.Join(" ", args);
            ExecuteProcess($"{filePath} {arguments}");
        }

        public void ExecuteProcessAsAdmin(string filePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-File \"{filePath}\"",
                UseShellExecute = true,
                CreateNoWindow = false,
                Verb = "runas"
            };
            Process.Start(startInfo);
        }

        public void ExecuteProcessAsAdmin(string filePath, string[] args)
        {
            string arguments = string.Join(" ", args);
            ExecuteProcessAsAdmin($"{filePath} {arguments}");
        }
    }
}
