using System;

public abstract class Harvester : Unit
{
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement) : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
            }

            this.energyRequirement = value;
        }
    }

    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(OreOutput)}");
            }

            this.oreOutput = value;
        }
    }

    public override string ToString()
    {
        return $"Ore Output: {this.OreOutput}\r\n" +
               $"Energy Requirement: {this.EnergyRequirement}\r\n";
    }
}