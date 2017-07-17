using System.Collections.Generic;

public class ProviderFactory
{
    public Provider GetProvider(List<string> args)
    {
        string type = args[0];

        switch (type)
        {
            case "Solar":
                return new SolarProvider(args[1], double.Parse(args[2]));

            case "Pressure":
            default:
                return new PressureProvider(args[1], double.Parse(args[2]));
        }
    }
}