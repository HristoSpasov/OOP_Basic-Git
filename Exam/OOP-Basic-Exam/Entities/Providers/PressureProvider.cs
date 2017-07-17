public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        this.EnergyOutput = this.EnergyOutput + (this.EnergyOutput * 50 / 100);
    }

    public override string ToString()
    {
        string name = this.GetType().Name;
        int ind = name.IndexOf("Provider");
        name = name.Insert(ind, " ");

        return $"{name} - {this.Id}\r\n" +
               $"{base.ToString()}".Trim();
    }
}