using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private DraftManager manager;

    public Engine()
    {
        this.isRunning = true;
        this.manager = new DraftManager();
    }

    public void Run()
    {
        while (isRunning)
        {
            string line = Console.ReadLine();

            this.ParseCommand(line);
        }
    }

    private void ParseCommand(string line)
    {
        List<string> args = line.Split().ToList();
        string command = args[0];
        args.RemoveAt(0);

        switch (command)
        {
            case "RegisterHarvester":
                Console.WriteLine(manager.RegisterHarvester(args).Trim());
                break;

            case "RegisterProvider":
                Console.WriteLine(manager.RegisterProvider(args).Trim());
                break;

            case "Day":
                Console.WriteLine(manager.Day().Trim());
                break;

            case "Mode":
                Console.WriteLine(manager.Mode(args).Trim());
                break;

            case "Check":
                Console.WriteLine(manager.Check(args).Trim());
                break;

            case "Shutdown":
                Console.WriteLine(manager.ShutDown().Trim());
                this.isRunning = false; // Stop reading commands
                break;
        }
    }
}