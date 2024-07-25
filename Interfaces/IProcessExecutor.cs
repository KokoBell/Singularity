namespace Singularity.Interfaces
{
    public interface IProcessExecutor
    {
        void ExecuteProcess(string filePath);
        void ExecuteProcess(string filePath, string[] args);
        void ExecuteProcessAsAdmin(string filePath);
        void ExecuteProcessAsAdmin(string filePath, string[] args);
    }
}
