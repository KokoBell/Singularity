namespace Singularity.Interfaces
{
    public interface IProcessExecutor
    {
        void ExecuteBatScript(string filePath);
        void ExecuteBatScript(string filePath, string[] args);
        void ExecuteBatScriptAsAdmin(string filePath);
        void ExecuteBatScriptAsAdmin(string filePath, string[] args);
    }
}
