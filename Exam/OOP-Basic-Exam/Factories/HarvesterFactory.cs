using System.Collections.Generic;

public class HarvesterFactory
{
    public Harvester GetHarvester(List<string> args)
    {
        string type = args[0];

        switch (type)
        {
            case "Sonic":
                return new SonicHarvester(args[1], double.Parse(args[2]), double.Parse(args[3]), int.Parse(args[4]));

            case "Hammer":
            default:
                return new HammerHarvester(args[1], double.Parse(args[2]), double.Parse(args[3]));
        }
    }
}