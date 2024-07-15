using Singularity.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singularity.Components
{
    public class ScriptHandler : IScriptHandler
    {
        public string currentScript = string.Empty;
        private readonly IFileChecker _fileChecker;
        private readonly IProcessExecutor _processExecutor;
        public ScriptHandler(IFileChecker fileChecker, IProcessExecutor processExecutor)
        {
            _fileChecker = fileChecker;
            _processExecutor = processExecutor;
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

        public void RunScript(string[] args)
        {
            if (string.IsNullOrEmpty(currentScript)) return;

            switch (args.Length)
            {
                case 0:
                    return;
                case 1:
                    RunScript();
                    break;
                default:
                    if (_fileChecker.CheckFileType(currentScript, "bat"))
                    {
                        _processExecutor.ExecuteBatScript(currentScript, args);
                    }
                    break;
            }
        }

        public void RunScript()
        {
            if (string.IsNullOrEmpty(currentScript)) return;

            if (_fileChecker.CheckFileType(currentScript, "bat"))
            {
                _processExecutor.ExecuteBatScript(currentScript);
            }
            else
            {
                throw new ArgumentException("Invalid file path provided");
            }
        }

        public void RunScriptAsAdmin()
        {
            if (string.IsNullOrEmpty(currentScript)) return;

            if (_fileChecker.CheckFileType(currentScript, "bat"))
            {
                _processExecutor.ExecuteBatScriptAsAdmin(currentScript);
            }
            else
            {
                throw new ArgumentException("Invalid file path provided");
            }
        }
    }
}
