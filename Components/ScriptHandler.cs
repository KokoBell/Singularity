using Singularity.Interfaces;

namespace Singularity.Components
{
    public class ScriptHandler : IScriptHandler
    {
        public string currentScript = string.Empty;
        public IProcessExecutor? processExecutor;
        private readonly IFileChecker _fileChecker;

        public ScriptHandler(IFileChecker fileChecker)
        {
            _fileChecker = fileChecker;
        }

        public string SelectScript()
        {
            OpenFileDialog openFileDialog = new();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentScript = openFileDialog.FileName;
                processExecutor = _fileChecker.GetExecutor(currentScript);
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
                    processExecutor?.ExecuteProcess(currentScript, args);
                    break;
            }
        }

        public void RunScript()
        {
            if (string.IsNullOrEmpty(currentScript)) return;

            processExecutor?.ExecuteProcess(currentScript);
        }

        public void RunScriptAsAdmin()
        {
            if (string.IsNullOrEmpty(currentScript)) return;

            processExecutor?.ExecuteProcessAsAdmin(currentScript);
        }

        public void RunScriptAsAdmin(string[] args)
        {
            if (string.IsNullOrEmpty(currentScript)) return;

            switch (args.Length)
            {
                case 0:
                    return;
                case 1:
                    RunScriptAsAdmin();
                    break;
                default:
                    processExecutor?.ExecuteProcessAsAdmin(currentScript, args);
                    break;
            }
        }
    }
}
