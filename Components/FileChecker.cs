using Singularity.Interfaces;

namespace Singularity.Components
{
    public class FileChecker : IFileChecker
    {
        public bool CheckFileType(string filePath, string fileExtension)
        {
            return Path.GetExtension(filePath).Replace(".", string.Empty).Equals(fileExtension, StringComparison.OrdinalIgnoreCase) && File.Exists(filePath);
        }
    }
}
