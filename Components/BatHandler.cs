using Singularity.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singularity.Components
{
    public class BatHandler : IScriptHandler
    {
        public string currentScript = string.Empty;
        public BatHandler()
        {
        }

        public string SelectScript()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentScript = openFileDialog.FileName;
            }

            return currentScript;
        }

        public void RunScript()
        {
            if (currentScript == string.Empty) return;

            if (Path.GetExtension(currentScript).Equals(".bat", StringComparison.OrdinalIgnoreCase) && File.Exists(currentScript))
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c \"{currentScript}\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = false;
                process.Start();
                process.WaitForExit();
            }
            else
            {
                throw new ArgumentException("Invalid .bat file path provided");
            }
        }
    }
}
