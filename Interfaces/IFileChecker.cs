namespace Singularity.Interfaces
{
    public interface IFileChecker
    {
        bool CheckFileType(string filePath, string fileExtension);
    }
}
