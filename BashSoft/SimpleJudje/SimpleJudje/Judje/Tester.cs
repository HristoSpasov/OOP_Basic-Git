using System;
using System.IO;

namespace SimpleJudje
{
    public class Tester
    {
        public void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            OutputWriter.WriteMessageOnNewLine("Reading files...");

            try
            {
                string mismatchPath = GetMismatchPath(expectedOutputPath);

                // Read data rom files
                string[] userOutput = File.ReadAllLines(userOutputPath);
                string[] expectedOutput = File.ReadAllLines(expectedOutputPath);

                // Compare
                bool hasMismatch;
                string[] mismatches = GetLinesWithPossibleMismatches(userOutput, expectedOutput, out hasMismatch);

                // Print report
                PrintOutput(mismatches, hasMismatch, mismatchPath);
                OutputWriter.WriteMessageOnNewLine("Files read!");
            }
            catch (FileNotFoundException)
            {
                OutputWriter.DisplayException(ExceptiionMessages.InvalidPath);
            }
            catch (DirectoryNotFoundException)
            {
                OutputWriter.DisplayException(ExceptiionMessages.InvalidPath);
            }
        }

        private void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchPath)
        {
            if (hasMismatch)
            {
                foreach (var mismatch in mismatches)
                {
                    OutputWriter.WriteMessageOnNewLine(mismatch);
                }

                try
                {
                    File.WriteAllLines(mismatchPath, mismatches);
                }
                catch (DirectoryNotFoundException)
                {
                    OutputWriter.DisplayException(ExceptiionMessages.InvalidPath);
                }
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine("Files are identical. There are no mismatches.");
            }
        }

        private string[] GetLinesWithPossibleMismatches(string[] userOutput, string[] expectedOutput, out bool hasMismatch)
        {
            // Helper variables
            hasMismatch = false;
            string output = string.Empty;

            // Check if files have same length
            int minOutputLines = userOutput.Length;

            if (userOutput.Length != expectedOutput.Length)
            {
                hasMismatch = true;
                minOutputLines = Math.Min(userOutput.Length, expectedOutput.Length);
                OutputWriter.DisplayException(ExceptiionMessages.ComparisonOfFilesWithDifferentSizes);
            }

            // Compare
            string[] mismatches = new string[userOutput.Length];
            OutputWriter.WriteMessageOnNewLine("Comparing files...");

            for (int i = 0; i < minOutputLines; i++)
            {
                string currUserLine = userOutput[i];
                string currExpectedLine = expectedOutput[i];

                if (!currUserLine.Equals(currExpectedLine))
                {
                    output = string.Format("Mismatch at line {0} --" +
                                           "expected: \"{1}\", actual: \"{2}\"",
                        i, currUserLine, currExpectedLine);
                    output += Environment.NewLine;

                    hasMismatch = true;
                }
                else
                {
                    output = currUserLine;
                    output += Environment.NewLine;
                }

                mismatches[i] = output;
            }

            return mismatches;
        }

        private string GetMismatchPath(string expectedOutputPath)
        {
            int indexOf = expectedOutputPath.LastIndexOf('\\');
            string directoryPath = expectedOutputPath.Substring(0, indexOf);
            string finalMismatchPath = directoryPath + @"Mismatches.txt";

            return finalMismatchPath;
        }
    }
}