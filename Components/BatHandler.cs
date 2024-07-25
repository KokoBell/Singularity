using Singularity.Interfaces;

namespace Singularity.Components
{
    public class BatHandler : IScriptHandler
    {
        public string currentScript = string.Empty;
        private readonly IProcessExecutor _processExecutor;
        public BatHandler(IProcessExecutor processExecutor)
        {
            _processExecutor = processExecutor;
        }

        public string SelectScript()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bat Files|*.bat";
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
                    _processExecutor.ExecuteProcess(currentScript, args);
                    break;
            }
        }

        public void RunScript()
        {
            if (string.IsNullOrEmpty(currentScript)) return;

            _processExecutor.ExecuteProcess(currentScript);
        }

        public bool RunScriptReturnValue(string[] args)
        {
            if (string.IsNullOrEmpty(currentScript)) return false;

            switch (args.Length)
            {
                case 0:
                    return false;
                case 1:
                    RunScript();
                    break;
                default:
                    _processExecutor.ExecuteProcess(currentScript, args);
                    break;

            }

            return true;
        }

        public void RunScriptAsAdmin()
        {
            if (string.IsNullOrEmpty(currentScript)) return;

            _processExecutor.ExecuteProcessAsAdmin(currentScript);
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
                    _processExecutor.ExecuteProcessAsAdmin(currentScript, args);
                    break;
            }
        }
    }
}
