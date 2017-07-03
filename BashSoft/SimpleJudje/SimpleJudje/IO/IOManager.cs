using System;
using System.IO;

namespace SimpleJudje
{
    public class IOManager
    {
        public void TraverseDirectory(int depth)
        {
            DirectoryInfo.TraverseDirectory(depth);
        }

        public void CreateDirectoryInCurrentFolder(string folderName)
        {
            string path = GetCurrentDirectoryPath() + "\\" + folderName;

            try
            {
                Directory.CreateDirectory(path);
            }
            catch (ArgumentException)
            {
                OutputWriter.DisplayException(ExceptiionMessages.ForbiddenSymbolsContainedInName);
            }
        }

        private string GetCurrentDirectoryPath()
        {
            return SessionData.currentPath;
        }

        public void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                try
                {
                    string currentPath = SessionData.currentPath;
                    int indexOfLastSlash = currentPath.LastIndexOf('\\');
                    string newPath = currentPath.Substring(0, indexOfLastSlash);

                    SessionData.currentPath = newPath;
                }
                catch (ArgumentOutOfRangeException)
                {
                    OutputWriter.DisplayException(ExceptiionMessages.UnableToGoHigherInPartitionHierarchy);
                }
            }
            else
            {
                string currentPath = SessionData.currentPath;
                currentPath += "\\" + relativePath;
                ChangeCurrentDirectoryAbsolute(currentPath);
            }
        }

        public void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                OutputWriter.DisplayException(ExceptiionMessages.InvalidPath);

                return; ;
            }

            SessionData.currentPath = absolutePath;
        }
    }
}