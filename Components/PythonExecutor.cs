using System.Diagnostics;

namespace Singularity.Interfaces
{
    public class PythonExecutor : IProcessExecutor
    {
        public void ExecuteProcess(string filePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"{filePath}",
            };
            Process.Start(startInfo);
            Process.GetCurrentProcess().WaitForExit();
        }

        public void ExecuteProcess(string filePath, string[] args)
        {
            string arguments = string.Join(" ", args);
            Process.Start("python", $"{filePath} {arguments}");
        }

        public void ExecuteProcessAsAdmin(string filePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = filePath,
                Verb = "runas",
                CreateNoWindow = false,
            };
            Process.Start(startInfo);
            Process.GetCurrentProcess().WaitForExit();
        }

        public void ExecuteProcessAsAdmin(string filePath, string[] args)
        {
            string arguments = string.Join(" ", args);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"{filePath} {arguments}",
                Verb = "runas"
            };
            Process.Start(startInfo);
        }
    }
}
