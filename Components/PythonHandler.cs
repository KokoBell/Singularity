using Singularity.Interfaces;

namespace Singularity.Components
{
    public class PythonHandler : IScriptHandler
    {

        private readonly IProcessExecutor _processExecutor;
        public string currentScript { get; private set; } = string.Empty;

        public PythonHandler(IProcessExecutor processExecutor)
        {
            _processExecutor = processExecutor;
        }

        public string SelectScript()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Python Files|*.py";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentScript = openFileDialog.FileName;
            }

            return currentScript;
        }

        public void RunScript()
        {
            _processExecutor.ExecuteProcess(currentScript);
        }

        public void RunScript(string[] args)
        {
            _processExecutor.ExecuteProcess(currentScript, args);
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
            _processExecutor.ExecuteProcessAsAdmin(currentScript);
        }

        public void RunScriptAsAdmin(string[] args)
        {
            _processExecutor.ExecuteProcessAsAdmin(currentScript, args);
        }
    }
}
