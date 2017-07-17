public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput = this.OreOutput + (this.OreOutput * Constants.HammerHarvesterPercentageOreOutputIncrease / 100);
        this.EnergyRequirement = this.EnergyRequirement + (this.EnergyRequirement * Constants.HammerHarvesterPercetageEnergyRequrementIncrease / 100);
    }

    public override string ToString()
    {
        string name = this.GetType().Name;
        int ind = name.IndexOf("Harvester");
        name = name.Insert(ind, " ");

        return $"{name} - {this.Id}\r\n" +
               $"{base.ToString()}".Trim();
    }
}