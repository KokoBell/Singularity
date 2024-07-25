using Singularity.Interfaces;

namespace Singularity.Components
{
    public class FileChecker : IFileChecker
    {
        // Filetypes here should correspond to those found in KnownFiletypeFilters setting
        public Dictionary<string, IProcessExecutor> FileTypeToExecutorMapping = new Dictionary<string, IProcessExecutor>
        {
            {".bat", new BatExecutor() },
            {".py", new PythonExecutor() },
            {".ps1", new PowershellExecutor() }
        };

        public bool CheckFileType(string filePath, string fileExtension)
        {
            return Path.GetExtension(filePath).Replace(".", string.Empty).Equals(fileExtension, StringComparison.OrdinalIgnoreCase) && File.Exists(filePath);
        }

        public string GetFileType(string filePath)
        {
            return Path.GetExtension(filePath).ToLower();
        }

        public IProcessExecutor? GetExecutor(string filePath)
        {
            string fileType = GetFileType(filePath);

            FileTypeToExecutorMapping.TryGetValue(fileType, out IProcessExecutor? e);

            return e;
        }


    }
}
