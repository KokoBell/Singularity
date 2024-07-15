namespace Singularity.Interfaces
{
    public interface IProcessExecutor
    {
        void ExecuteBatScript(string filePath);
        void ExecuteBatScriptAsAdmin(string filePath);
    }
}
