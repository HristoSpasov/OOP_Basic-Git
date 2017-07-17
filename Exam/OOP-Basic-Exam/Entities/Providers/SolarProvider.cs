public class SolarProvider : Provider
{
    public SolarProvider(string id, double energyOutput) : base(id, energyOutput)
    {
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