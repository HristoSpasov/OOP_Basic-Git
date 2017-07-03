using System;

namespace SimpleJudje
{
    public class InputReader
    {
        private const string endComand = "quit";
        private CommandInterpreter interpreter;

        public InputReader(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingComands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
            string input = Console.ReadLine();
            input = input.Trim();
            interpreter.InterpredCommand(input); // Proces command input

            while (true)
            {
                // Interpret command
                OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
                input = Console.ReadLine();
                input = input.Trim();

                interpreter.InterpredCommand(input); // Proces command input

                if (input == endComand)
                {
                    // Close program
                    break;
                }
            }
        }
    }
}