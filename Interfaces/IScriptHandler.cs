namespace Singularity.Interfaces
{
    public interface IScriptHandler
    {
        string SelectScript();
        void RunScript();
        public bool RunScriptReturnValue(string[] args);
        void RunScript(string[] args);
        void RunScriptAsAdmin();
        void RunScriptAsAdmin(string[] args);
    }
}
