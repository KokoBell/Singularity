namespace Singularity.Interfaces
{
    public interface IScriptHandler
    {
        string SelectScript();
        void RunScript();
        void RunScript(string[] args);
        void RunScriptAsAdmin();
        void RunScriptAsAdmin(string[] args);
    }
}
