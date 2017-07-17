public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
    {
        this.sonicFactor = sonicFactor;
        this.EnergyRequirement = this.EnergyRequirement / this.sonicFactor;
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