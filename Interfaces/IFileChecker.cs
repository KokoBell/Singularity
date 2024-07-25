namespace Singularity.Interfaces
{
    public interface IFileChecker
    {
        bool CheckFileType(string filePath, string fileExtension);
        string GetFileType(string filePath);
        IProcessExecutor? GetExecutor(string filePath);
    }
}
