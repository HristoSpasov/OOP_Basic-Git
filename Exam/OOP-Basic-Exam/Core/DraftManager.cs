using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string mode;
    private double storedEnergy;
    private double storedOre;
    private List<Harvester> harvesters;
    private List<Provider> providers;

    public List<Harvester> Harvesters => this.harvesters;

    public List<Provider> Providers => this.providers;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.mode = "Full";
        this.storedEnergy = 0.0;
        this.storedOre = 0.0;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        string output = string.Empty;

        try
        {
            HarvesterFactory hf = new HarvesterFactory();
            Harvester newHarvester = hf.GetHarvester(arguments);
            this.harvesters.Add(newHarvester);

            string name = newHarvester.GetType().Name;
            int ind = name.IndexOf("Harvester");
            name = name.Insert(ind, " ");

            output = $"Successfully registered {name} - {newHarvester.Id}";
        }
        catch (Exception e)
        {
            output = e.Message;
        }

        return output;
    }

    public string RegisterProvider(List<string> arguments)
    {
        string output = string.Empty;

        try
        {
            ProviderFactory pf = new ProviderFactory();

            Provider newProvider = pf.GetProvider(arguments);
            this.providers.Add(newProvider);

            string name = newProvider.GetType().Name;
            int ind = name.IndexOf("Provider");
            name = name.Insert(ind, " ");

            output = $"Successfully registered {name} - {newProvider.Id}";
        }
        catch (Exception e)
        {
            output = e.Message;
        }

        return output;
    }

    public string Day()
    {
        // Get day params
        double oreProduced = harvesters.Sum(op => op.OreOutput);
        double energyProduced = this.providers.Sum(ep => ep.EnergyOutput);
        double currentEnergyRequred = this.harvesters.Sum(cer => cer.EnergyRequirement);

        switch (this.mode)
        {
            case "Half":
                {
                    oreProduced = oreProduced * 50 / 100;
                    currentEnergyRequred = currentEnergyRequred * 60 / 100;
                }
                break;

            case "Energy":
                {
                    oreProduced = 0;
                    currentEnergyRequred = 0;
                }
                break;
        }

        this.storedEnergy += energyProduced; // Add energy to all stored enery

        if (currentEnergyRequred <= this.storedEnergy)
        {
            this.storedOre += oreProduced;
            this.storedEnergy -= currentEnergyRequred;

            return $"A day has passed.\r\n" +
                   $"Energy Provided: {energyProduced}\r\n" +
                   $"Plumbus Ore Mined: {oreProduced}\r\n".Trim();
        }

        return $"A day has passed.\r\n" +
                  $"Energy Provided: {energyProduced}\r\n" +
                  $"Plumbus Ore Mined: 0\r\n".Trim();
    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {this.mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];

        Harvester searchHarvester = this.harvesters.FirstOrDefault(i => i.Id == id);
        Provider searchProvider = this.providers.FirstOrDefault(i => i.Id == id);

        if (searchHarvester != null)
        {
            // Harvester is found
            return searchHarvester.ToString().Trim();
        }
        else if (searchProvider != null)
        {
            // Return provider
            return searchProvider.ToString().Trim();
        }

        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();

        return $"System Shutdown\r\n" +
               $"Total Energy Stored: {this.storedEnergy}\r\n" +
               $"Total Mined Plumbus Ore: {this.storedOre}\r\n".Trim();
    }
}